import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import {RouterModule} from '@angular/router';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatTableModule} from '@angular/material/table';
import {MatButtonModule} from '@angular/material/button';
import {MatCardModule} from '@angular/material/card';
import {MatDividerModule} from '@angular/material/divider';
import {MatInputModule} from '@angular/material/input';
import {MatDialogModule} from '@angular/material/dialog';
import {MatIconModule} from '@angular/material/icon';
import {MatGridListModule} from '@angular/material/grid-list';

import { CreateComponent } from './create/create.component';
import { DetailsComponent } from './details/details.component';
import { DeleteComponent } from './delete/delete.component';
import { ListComponent } from './list/list.component';
import { ShippersService } from './shippers.service';



@NgModule({
  declarations: [
    CreateComponent,
    DetailsComponent,
    DeleteComponent,
    ListComponent,
  ],
  imports: [
    CommonModule,
    FormsModule,
    RouterModule,
    MatFormFieldModule,
    MatTableModule,
    MatButtonModule,
    MatCardModule,
    MatInputModule,
    MatDividerModule,
    MatDialogModule,
    MatIconModule,
    MatGridListModule
  ],
  providers: [
    ShippersService,
  ]
})
export class ShippersModule { }
