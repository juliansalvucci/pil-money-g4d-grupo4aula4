//MÓDULOS
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MaterialModule } from 'src/app/material/material.module';
import { FormsModule } from '@angular/forms';
import { DepositoRoutingModule } from './deposito-routing.module';

//COMPONENTES
import { SeleccionComponent } from './seleccion/seleccion.component';
import { PagoEfectivoComponent } from './pago-efectivo/pago-efectivo.component';
import { PagoTarjetaDebitoComponent } from './pago-tarjeta-debito/pago-tarjeta-debito.component';
import { TarjetaComponent } from './pago-tarjeta-debito/tarjeta/tarjeta.component';
import { TablaDepositoComponent } from './tabla-deposito/tabla-deposito.component';




@NgModule({
  declarations: [
    SeleccionComponent,
    PagoEfectivoComponent,
    PagoTarjetaDebitoComponent,
    TarjetaComponent,
    TablaDepositoComponent,
  ],
  imports: [
    CommonModule,
    DepositoRoutingModule,
    MaterialModule,
    FormsModule,
  ],
  exports: [
    SeleccionComponent,
    PagoEfectivoComponent,
    PagoTarjetaDebitoComponent,
    TablaDepositoComponent,
  ]
})
export class DepositoModule { }
