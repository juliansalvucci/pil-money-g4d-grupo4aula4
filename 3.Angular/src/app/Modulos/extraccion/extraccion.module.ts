import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { OpcionExtraccionComponent } from './opcion-extraccion/opcion-extraccion.component';
import { MaterialModule } from 'src/app/Material/material.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';




@NgModule({
  declarations: [
    OpcionExtraccionComponent
  ],
  imports: [
    CommonModule,
    MaterialModule,
    FormsModule,
    ReactiveFormsModule
  ],
  exports:[
    OpcionExtraccionComponent
  ]
})
export class ExtraccionModule { }
