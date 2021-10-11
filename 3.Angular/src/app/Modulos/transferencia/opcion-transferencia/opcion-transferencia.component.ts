import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Cuenta } from 'src/app/Interfaces/Cuenta';
import { Destino } from 'src/app/Interfaces/Destino';
import { CuentaService } from 'src/app/Servicios/cuenta.service';
import { DepositoService } from 'src/app/Servicios/deposito.service';
import { DestinoService } from 'src/app/Servicios/destino.service';
import { TransferenciaService } from 'src/app/Servicios/transferencia.service';



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
    if(this.transferenciaForm.valid){
      console.log(this.transferenciaForm.value);
      this.transferenciaService.Transferir(this.transferenciaForm.value).subscribe(
        (data) => {
          console.log(data);
        }
      )
    }
  }

}
