import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute } from '@angular/router'
import { DeleteComponent } from '../delete/delete.component';
import { ShippersService, Shipper } from '../shippers.service';

@Component({
  selector: '.container',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {
  shippers: Shipper[] = [];
  error: string = '';
  displayedColumns: string[] = ['Id', 'CompanyName', 'Phone', 'Actions'];

  constructor(private route: ActivatedRoute, 
              private shippersService: ShippersService, 
              public dialog: MatDialog) { }

  ngOnInit(): void {
    this.getShippers();
  }

  getShippers(){
    this.shippersService.getShippers()
    .subscribe({
      next: (data: Shipper[]) => this.shippers = data,
      error: error => this.error = error,
    });
  }

  openDeleteDialog(shipper: Shipper){
    this.dialog.open(DeleteComponent, {
      width: '250px',
      enterAnimationDuration: '0ms',
      exitAnimationDuration: '0ms',
      data: shipper
    });
  }
}
