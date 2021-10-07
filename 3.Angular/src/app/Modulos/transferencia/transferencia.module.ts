//MÓDULOS
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MaterialModule } from 'src/app/Material/material.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

//COMPONENTES
import { TransferenciaRoutingModule } from './transferencia-routing.module';
import { OpcionTransferenciaComponent } from './opcion-transferencia/opcion-transferencia.component';
import { TablaTransferenciaComponent } from './tabla-transferencia/tabla-transferencia.component';






@NgModule({
  declarations: [
    OpcionTransferenciaComponent,
    TablaTransferenciaComponent
  ],
  imports: [
    CommonModule,
    TransferenciaRoutingModule,
    MaterialModule,
    FormsModule,
    ReactiveFormsModule
  ],
  exports:[
    OpcionTransferenciaComponent,
    TablaTransferenciaComponent
  ]
})
export class TransferenciaModule { }
