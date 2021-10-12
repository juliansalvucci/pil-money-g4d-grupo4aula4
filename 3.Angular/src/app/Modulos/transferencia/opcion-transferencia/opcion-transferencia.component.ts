import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Cuenta } from 'src/app/Interfaces/Cuenta';
import { Destino } from 'src/app/Interfaces/Destino';
import { CuentaService } from 'src/app/Servicios/cuenta.service';
import { DepositoService } from 'src/app/Servicios/deposito.service';
import { DestinoService } from 'src/app/Servicios/destino.service';
import { TransferenciaService } from 'src/app/Servicios/transferencia.service';
import Swal from 'sweetalert2';



@Component({
  selector: 'app-opcion-transferencia',
  templateUrl: './opcion-transferencia.component.html',
  styleUrls: ['./opcion-transferencia.component.css']
})
export class OpcionTransferenciaComponent {
  listaCuentas!: Cuenta[];
  listaDestinos!: Destino[];

  constructor(private fb: FormBuilder, 
    private cuentaService: CuentaService, 
    private destinoService: DestinoService, 
    private transferenciaService: TransferenciaService){
      this.getCuentas();
      this.getDestinos();
    }
 

  transferenciaForm: FormGroup = this.fb.group({
    idTransferencia: [0],
    cvu: [,[Validators.required]],
    monto: [,[Validators.required]],
    nota: [,],
    aliasDestino: [,[Validators.required]],
  });

  getCuentas(){
    this.cuentaService.obtenerCuentas().subscribe(r => {
      console.log(r);
      this.listaCuentas = r;

    })
  }

  getDestinos(){
    this.destinoService.ObtenerDestinos().subscribe(r => {
      console.log(r);
      this.listaDestinos = r;
    })
  }

  transferir(){

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
    
    if(this.transferenciaForm.valid){
      console.log(this.transferenciaForm.value);
      this.transferenciaService.Transferir(this.transferenciaForm.value).subscribe(
        (data) => {
          Toast.fire({
            icon: 'success',
            title: 'Transferencia exitosa',
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
