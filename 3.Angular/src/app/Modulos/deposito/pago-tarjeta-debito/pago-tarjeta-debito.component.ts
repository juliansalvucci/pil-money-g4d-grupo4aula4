import { Component } from '@angular/core';
import { TarjetaComponent } from './tarjeta/tarjeta.component';
import { MatDialog } from '@angular/material/dialog';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Deposito } from 'src/app/Interfaces/Deposito';
import { CuentaService } from 'src/app/Servicios/cuenta.service';
import { DepositoService } from 'src/app/Servicios/deposito.service';
import { Cuenta } from 'src/app/Interfaces/Cuenta';
import Swal from 'sweetalert2';


@Component({
  selector: 'app-pago-tarjeta-debito',
  templateUrl: './pago-tarjeta-debito.component.html',
  styleUrls: ['./pago-tarjeta-debito.component.css']
})






export class PagoTarjetaDebitoComponent {

  listaCuentas!: Cuenta[];

  currentUser = JSON.parse(localStorage.getItem('currentUser') || '{}');
 

  depositoForm: FormGroup = this.fb.group({
    idDeposito: [0],
    cvu: [,[Validators.required]],
    monto: [,[Validators.required]],
  });

  constructor(private fb: FormBuilder, private cuentaService: CuentaService, private depositoService: DepositoService){ 
    this.getCuentas();
    this.currentUser;
  }

  getCuentas(){
    this.cuentaService.obtenerCuentas().subscribe(r => {
      console.log(r);
      this.listaCuentas = r;

    })
  }
  
  depositar(){

    const Toast = Swal.mixin({
      //Declaro el mixin de sweet alert 2
      toast: true,
      position: 'top-end',
      showConfirmButton: false,
      timer: 3000,
      timerProgressBar: true,
      didOpen: (toast) => {
        toast.addEventListener('mouseenter', Swal.stopTimer);
        toast.addEventListener('mouseleave', Swal.resumeTimer);
      },
    });
    
    if(this.depositoForm.valid){
      console.log(this.depositoForm.value);
      this.depositoService.Depositar(this.depositoForm.value).subscribe(
        (data) => {
          Toast.fire({
            icon: 'success',
            title: 'Depósito exitoso',
          });
          console.log(data);
        },
        (error) => {
          console.log(error);
          Toast.fire({
              icon: 'error',
              title: `Error de servidor`,
          });
        }
      )
    }
  }

}
  


