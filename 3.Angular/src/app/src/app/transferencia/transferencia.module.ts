//MÓDULOS
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MaterialModule } from 'src/app/material/material.module';

//COMPONENTES
import { TransferenciaRoutingModule } from './transferencia-routing.module';
import { OpcionTransferenciaComponent } from './opcion-transferencia/opcion-transferencia.component';




@NgModule({
  declarations: [
    OpcionTransferenciaComponent
  ],
  imports: [
    CommonModule,
    TransferenciaRoutingModule,
    MaterialModule
  ],
  exports:[
    OpcionTransferenciaComponent
  ]
})
export class TransferenciaModule { }
