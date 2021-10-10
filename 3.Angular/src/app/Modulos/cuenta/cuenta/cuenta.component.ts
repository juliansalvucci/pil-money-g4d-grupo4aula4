import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Cuenta } from 'src/app/Interfaces/Cuenta';
import { TipoMoneda } from 'src/app/Interfaces/TipoMoneda';
import { CuentaService } from 'src/app/Servicios/cuenta.service';
import { TipoMonedaService } from 'src/app/Servicios/tipo-moneda.service';
import { Usuario } from 'src/app/Servicios/usuario.service';

@Component({
  selector: 'app-cuenta',
  templateUrl: './cuenta.component.html',
  styleUrls: ['./cuenta.component.css']
})
export class CuentaComponent {

  listaCuentas!: Cuenta[];
  listaTiposMoneda!: TipoMoneda[];
  usuario : Usuario = JSON.parse(localStorage.getItem('currentUser') || '{}');

  cuentaForm: FormGroup = this.fb.group({
    cvu: [0],
    alias: [,[Validators.required]],
    saldo:[0],
    dni: [this.usuario.dni],
    idTipoMoneda:[,[Validators.required]]
  });

  constructor(private fb: FormBuilder ,private cuentaService: CuentaService, private tipoMonedaService: TipoMonedaService){
      this.getCuentas();
      this.getTipoMoneda();
  }

  getCuentas(){
    this.cuentaService.obtenerCuentas().subscribe(r => {
      console.log(r);
      this.listaCuentas = r;
    })
  }

  getTipoMoneda(){
    this.tipoMonedaService.obtenerTipoMoneda().subscribe(r => {
      console.log(r);
      this.listaTiposMoneda= r;
    })
  }

  crearCuenta(){
    if(this.cuentaForm.valid){
      console.log(this.cuentaForm.value);
      this.cuentaService.crearCuenta(this.cuentaForm.value).subscribe(
        (data) => {
          console.log(data);
        }
      )
    }
  }

}
