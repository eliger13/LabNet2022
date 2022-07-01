import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router'
import { ShippersService, Shipper } from '../shippers.service';


@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.scss']
})
export class CreateComponent implements OnInit {
  shipper: Omit<Shipper, 'Id'> = { CompanyName: '', Phone: ''}; 
  error: string = '';

  constructor(private router: Router, private shippersService: ShippersService) { }

  ngOnInit(): void {
  }

  create(){
    if(this.shipper){
      this.shippersService.addShipper(this.shipper)
        .subscribe({
          next: (data: Shipper) => this.router.navigate(['/details', data.Id]),
          error: error => this.error = error,
       })
    }
  }
}
