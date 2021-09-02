//MÓDULOS 
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { OperacionesRoutingModule } from './operaciones-routing.module';
import { MaterialModule } from 'src/app/material/material.module';

//COMPONENTES
import { ResumenComponent } from './resumen/resumen.component';

@NgModule({
  declarations: [
    ResumenComponent
  ],
  imports: [
    CommonModule,
    OperacionesRoutingModule,
    MaterialModule
  ],
  exports: [
    ResumenComponent
  ]

})
export class OperacionesModule { }
