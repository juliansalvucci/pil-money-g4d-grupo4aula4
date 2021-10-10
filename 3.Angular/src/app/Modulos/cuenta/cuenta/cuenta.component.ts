import { Component, OnInit } from '@angular/core';
import { Cuenta } from 'src/app/Interfaces/Cuenta';
import { CuentaService } from 'src/app/Servicios/cuenta.service';
import { TipoMonedaService } from 'src/app/Servicios/tipo-moneda.service';

@Component({
  selector: 'app-cuenta',
  templateUrl: './cuenta.component.html',
  styleUrls: ['./cuenta.component.css']
})
export class CuentaComponent {

  listaCuentas!: Cuenta[];

  constructor(private cuentaService: CuentaService, private tipoMonedaService: TipoMonedaService){
      this.getCuentas();
  }

  getCuentas(){
    this.cuentaService.obtenerCuentas().subscribe(r => {
      console.log(r);
      this.listaCuentas = r;
    })
  }

  getTipoMonedas(){}

}
