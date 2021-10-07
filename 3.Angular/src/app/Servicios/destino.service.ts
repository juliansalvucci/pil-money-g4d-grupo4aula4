import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Time } from '@angular/common';

const url ="https://localhost:44339/api/Cuenta";
const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

export class Destino{
  cvuAlias: string=""; 
  propietario: string=""; 
  correo: string="";
  dni: number=0;
}

@Injectable({
  providedIn: 'root'
})
export class DestinoService {

  constructor(private http:HttpClient) {
    console.log("Servicio Cuentas está corriendo");
  }

  ListarDestinos():Observable<any>{
    return this.http.get<any>(url,httpOptions);
  }
}
