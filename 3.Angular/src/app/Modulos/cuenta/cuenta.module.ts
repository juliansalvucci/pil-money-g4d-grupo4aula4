import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CuentaComponent } from './cuenta/cuenta.component';
import { MaterialModule } from 'src/app/Material/material.module';
import { CuentaCreateComponent } from './cuenta-create/cuenta-create.component';




@NgModule({
  declarations: [
    CuentaComponent,
    CuentaCreateComponent
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
