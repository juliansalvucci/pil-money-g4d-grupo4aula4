import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CuentaComponent } from './cuenta/cuenta.component';
import { MaterialModule } from 'src/app/Material/material.module';




@NgModule({
  declarations: [
    CuentaComponent,
  ],
  imports: [
    CommonModule,
    MaterialModule
  ],
  exports: [
    CuentaComponent,
  ]
})
export class CuentaModule { }
