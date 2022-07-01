import { Component, OnInit, Inject } from '@angular/core';
import { Router } from '@angular/router'
import {MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
import { ShippersService, Shipper } from '../shippers.service';

@Component({
  selector: 'app-delete',
  templateUrl: './delete.component.html',
  styleUrls: ['./delete.component.scss']
})
export class DeleteComponent implements OnInit {

  constructor(public dialogRef: MatDialogRef<DeleteComponent>,
              @Inject(MAT_DIALOG_DATA) public data: Shipper,
              private router: Router,
              private shippersService: ShippersService) {}

  ngOnInit(): void {
    this.router.routeReuseStrategy.shouldReuseRoute = () => false;
  }

  delete() {
    this.shippersService.deleteShipper(this.data.Id)
    .subscribe({
      next: data => this.router.navigate(['/']),
      error: error => console.error(error)
    })
  }
}
