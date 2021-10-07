import { Component } from '@angular/core';
import { TarjetaComponent } from './tarjeta/tarjeta.component';
import { MatDialog } from '@angular/material/dialog';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Deposito } from 'src/app/Servicios/deposito.service';



interface Animal {
  name: string;
  sound: string;
}

@Component({
  selector: 'app-pago-tarjeta-debito',
  templateUrl: './pago-tarjeta-debito.component.html',
  styleUrls: ['./pago-tarjeta-debito.component.css']
})

/*
listaCuentas: cuentas[];
listaTarjetas: tarjetas[]
*/


export class PagoTarjetaDebitoComponent {

  deposito = new Deposito()
  

  depositoForm: FormGroup = this.fb.group({
    cuenta: [,[Validators.required]],
    monto: [,[Validators.required]],
    tarjeta: [,[Validators.required]],
  });

  constructor(private fb: FormBuilder){}

  depositoControl = new FormControl('', Validators.required);
  
  onEnviar(value: any){
    console.log(value);
  }
}
  


