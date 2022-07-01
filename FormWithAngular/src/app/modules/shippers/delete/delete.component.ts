import { Component, OnInit, Inject } from '@angular/core';
import { Router } from '@angular/router'
import {MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
import { ShippersService, Shipper } from '../shippers.service';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-delete',
  templateUrl: './delete.component.html',
  styleUrls: ['./delete.component.scss']
})
export class DeleteComponent implements OnInit {

  constructor(public dialogRef: MatDialogRef<DeleteComponent>,
              @Inject(MAT_DIALOG_DATA) public data: Shipper,
              private router: Router,
              private shippersService: ShippersService,
              private snackBar: MatSnackBar) {}

  ngOnInit(): void {
    this.router.routeReuseStrategy.shouldReuseRoute = () => false;
  }

  delete() {
    this.shippersService.deleteShipper(this.data.Id)
    .subscribe({
      next: data => this.router.navigate(['/']),
      error: error => this.snackBar.openFromComponent(DeleteErrorNotification, {
        duration: 10 * 1000
      })
    })
  }
}

@Component({
  selector: 'app-delete-notification',
  template: `<span>Error deleting the Shipper.</span>`,
})
class DeleteErrorNotification implements OnInit {
  ngOnInit(): void {
  }
}