import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateComponent } from './modules/shippers/create/create.component';
import { DeleteComponent } from './modules/shippers/delete/delete.component';
import { DetailsComponent } from './modules/shippers/details/details.component';
import { ListComponent } from './modules/shippers/list/list.component';

const routes: Routes = [{
  path: '',
  redirectTo: 'home',
  pathMatch: 'full'
},
{
  path: 'home',
  component: ListComponent
},
{
  path: 'create',
  component: CreateComponent
},
{
  path: 'details/:id',
  component: DetailsComponent
},
{
  path: 'delete/:id',
  component: DeleteComponent
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
