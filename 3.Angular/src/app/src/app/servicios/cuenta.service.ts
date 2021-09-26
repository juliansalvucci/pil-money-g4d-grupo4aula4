import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';

const url ="https://localhost:44339/api/Cuenta";
const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

export class Cuenta{
   cvu: number=0;
   alias: string="";
   saldo: number=0;
   usuarioDni: number=0;
   tipoMoneda: number=0;
}

@Injectable({
  providedIn: 'root'
})
export class CuentaService {

  constructor(private http:HttpClient) {
    console.log("Servicio Cuentas está corriendo");
  }

  crearCuenta(cuenta: Cuenta):Observable<Cuenta>{
    return this.http.post<Cuenta>(url, cuenta, httpOptions);
  }

  obtenerCuentas():Observable<any>{
    return this.http.get<any>(url,httpOptions);
  }


}
