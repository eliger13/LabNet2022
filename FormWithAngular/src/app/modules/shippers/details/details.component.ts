import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router'
import {MatDialog} from '@angular/material/dialog';

import { ShippersService, Shipper } from '../shippers.service';
import { DeleteComponent } from '../delete/delete.component';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.scss']
})
export class DetailsComponent implements OnInit {
  shipper: Shipper = {Id: 0, CompanyName: '', Phone: ''};
  originalShipper: any;
  id: number | undefined;
  error: string = '';
  isEditing: boolean = false;

  constructor(private route: ActivatedRoute,              
              private router: Router,
              private shippersService: ShippersService, 
              public dialog: MatDialog) { }

  ngOnInit(): void {
    this.router.routeReuseStrategy.shouldReuseRoute = () => false;

    this.id = parseInt(this.route.snapshot.paramMap.get('id') || '')

    this.shippersService.getShipper(this.id)
      .subscribe({
          next: (data: Shipper) => {
            this.shipper = {...data};
            this.originalShipper = {...data};
          },
          error: error => this.error = error
        });
  }

  edit(){
    this.isEditing = true;
  }

  update(){
    if(this.shipper && this.isEditing){
      this.shippersService.updateShipper(this.shipper)
        .subscribe({
          next: (data: Shipper) => this.shipper = data,
          error: error => this.error = error,
       }).add(() => {
        this.isEditing = false
       })
    }
  }

  cancel(){
    this.isEditing = false
    this.shipper = {...this.originalShipper}
  }

  openDeleteDialog(){
    this.dialog.open(DeleteComponent, {
      width: '250px',
      enterAnimationDuration: '0ms',
      exitAnimationDuration: '0ms',
      data: this.shipper
    });
  }

}
