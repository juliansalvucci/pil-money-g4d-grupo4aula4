import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
//import { Deposito, Cuenta, Tarjeta } from '../../servicios/deposito.service';



interface Animal {
  name: string;
  sound: string;
}

@Component({
  selector: 'app-pago-tarjeta-debito',
  templateUrl: './pago-tarjeta-debito.component.html',
  styleUrls: ['./pago-tarjeta-debito.component.css']
})






export class PagoTarjetaDebitoComponent {

  /*
  listaCuentas = Cuenta;
  listaTarjetas = Tarjeta;  
  */

  depositoForm: FormGroup = this.fb.group({
    cuenta: [,[Validators.required]],
    monto: [,[Validators.required]],
    tarjeta: [,[Validators.required]],
  });

  constructor(private fb: FormBuilder){}

  depositoControl = new FormControl('', Validators.required);
  
  
}
  


