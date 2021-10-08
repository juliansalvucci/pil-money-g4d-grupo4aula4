import { Component } from '@angular/core';
import { TarjetaComponent } from './tarjeta/tarjeta.component';
import { MatDialog } from '@angular/material/dialog';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Cuenta, Deposito } from 'src/app/Interfaces/Deposito';
import { CuentaService } from 'src/app/Servicios/cuenta.service';
import { DepositoService } from 'src/app/Servicios/deposito.service';


@Component({
  selector: 'app-pago-tarjeta-debito',
  templateUrl: './pago-tarjeta-debito.component.html',
  styleUrls: ['./pago-tarjeta-debito.component.css']
})






export class PagoTarjetaDebitoComponent {

  listaCuentas!: Cuenta[];
 

  depositoForm: FormGroup = this.fb.group({
    idDeposito: [0],
    cuenta: [,[Validators.required]],
    monto: [,[Validators.required]],
  });

  constructor(private fb: FormBuilder, private cuentaService: CuentaService, private depositoService: DepositoService){ 
    this.getCuentas();
  }

  getCuentas(){
    this.cuentaService.obtenerCuentas().subscribe(r => {
      console.log(r);
      this.listaCuentas = r;

    })
  }
  
  depositar(){
    if(this.depositoForm.valid){
      console.log(this.depositoForm.value);
      this.depositoService.Depositar(this.depositoForm.value).subscribe(
        (data) => {
          console.log(data);
        },
      )
    }
  }

}
  


