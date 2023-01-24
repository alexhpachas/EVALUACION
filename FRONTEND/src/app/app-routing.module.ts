import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TrabajadorComponent } from './components/trabajador/trabajador.component';

const routes: Routes = [
  {path:'',redirectTo:'trabajador',pathMatch:'full'},
  {path:'trabajador', component:TrabajadorComponent},
  {path: '**',redirectTo:'trabajador',pathMatch:'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
