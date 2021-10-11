import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Cuenta } from '../Interfaces/Cuenta';

const url ="https://localhost:44354/api/Cuenta";
const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};



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

  obtenerCuentas():Observable<Cuenta[]>{
    return this.http.get<any>(url,httpOptions);
  }


}
