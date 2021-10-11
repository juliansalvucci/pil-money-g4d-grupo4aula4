import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CuentaComponent } from './cuenta/cuenta.component';
import { MaterialModule } from 'src/app/Material/material.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CuentaCreateComponent } from './cuenta-create/cuenta-create.component';




@NgModule({
  declarations: [
    CuentaComponent,
    CuentaCreateComponent,
  ],
  imports: [
    CommonModule,
    MaterialModule,
    FormsModule,
    ReactiveFormsModule
  ],
  exports: [
    CuentaComponent,
    CuentaCreateComponent
  ]
})
export class CuentaModule { }
