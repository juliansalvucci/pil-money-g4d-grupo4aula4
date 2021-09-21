import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CuentaComponent } from './cuenta/cuenta.component';



@NgModule({
  declarations: [
    CuentaComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    CuentaComponent
  ]
})
export class CuentaModule { }
