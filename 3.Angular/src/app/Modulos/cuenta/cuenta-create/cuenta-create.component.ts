import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { TipoMoneda } from 'src/app/Interfaces/TipoMoneda';
import { CuentaService } from 'src/app/Servicios/cuenta.service';
import { TipoMonedaService } from 'src/app/Servicios/tipo-moneda.service';

@Component({
  selector: 'app-cuenta-create',
  templateUrl: './cuenta-create.component.html',
  styleUrls: ['./cuenta-create.component.css']
})
export class CuentaCreateComponent  {

  listaTiposMoneda!: TipoMoneda[];

  currentUser = JSON.parse(localStorage.getItem('currentUser') || '{}');
  dni = this.currentUser.dni


  cuentaForm: FormGroup = this.fb.group({
    cvu: [0],
    alias: [,[Validators.required]],
    saldo:[0],
    dni: [this.dni],
    idTipoMoneda:[,[Validators.required]]
  });

  constructor(private fb: FormBuilder ,private cuentaService: CuentaService, private tipoMonedaService: TipoMonedaService){
    this.getTipoMoneda();
    this.crearCuenta();
    this.currentUser
  }
   
  getTipoMoneda(){
    this.tipoMonedaService.obtenerTipoMoneda().subscribe(r => {
      console.log(r);
      this.listaTiposMoneda= r;
    })
  }

  crearCuenta(){
    console.log(this.cuentaForm)
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
