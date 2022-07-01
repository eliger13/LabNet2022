import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { observableToBeFn } from 'rxjs/internal/testing/TestScheduler';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type':  'application/json'
  })
};

export interface Shipper{
  Id: number;
  CompanyName: string;
  Phone: string;
}

@Injectable()
export class ShippersService {
  url = "https://localhost:44383/api/shippers/"
  
  constructor(private http: HttpClient) { }

  getShippers(): Observable<Shipper[]>{
    return this.http.get<Shipper[]>(this.url).pipe(
      catchError(this.handleError)
    );
  }

  getShipper(Id: number): Observable<Shipper>{
    return this.http.get<Shipper>(this.url + Id)
      .pipe(
        catchError(this.handleError)
      )
  }

  addShipper(shipper: Omit<Shipper, 'Id'>): Observable<Shipper>{
    return this.http.post<Shipper>(this.url, shipper, httpOptions)
      .pipe(
        catchError(this.handleError)
      )
  }

  updateShipper(shipper: Shipper): Observable<Shipper>{
    return this.http.put<Shipper>(this.url + shipper.Id, shipper, httpOptions)
      .pipe(
        catchError(this.handleError)
      )
  }

  deleteShipper(Id: number): Observable<unknown>{
    return this.http.delete(this.url + Id, httpOptions)
      .pipe(
        catchError(this.handleError)
      )
  }

  private handleError(error: HttpErrorResponse) {
    if (error.status === 0) {
      console.error('An error occurred:', error.error);
    } else {
      console.error(
        `Backend returned code ${error.status}, body was: `, error.error);
    }
    return throwError(() => new Error('Something bad happened; please try again later.'));
  }
}