import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DepositoRoutingModule } from './deposito-routing.module';
import { SeleccionComponent } from './seleccion/seleccion.component';
import { PagoEfectivoComponent } from './pago-efectivo/pago-efectivo.component';
import { PagoTarjetaDebitoComponent } from './pago-tarjeta-debito/pago-tarjeta-debito.component';


@NgModule({
  declarations: [
    SeleccionComponent,
    PagoEfectivoComponent,
    PagoTarjetaDebitoComponent
  ],
  imports: [
    CommonModule,
    DepositoRoutingModule
  ]
})
export class DepositoModule { }
