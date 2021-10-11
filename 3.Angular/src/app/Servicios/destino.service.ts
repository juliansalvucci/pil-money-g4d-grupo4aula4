import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Time } from '@angular/common';

const url ="https://localhost:44354/api/Destino";
const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};


@Injectable({
  providedIn: 'root'
})
export class DestinoService {

  constructor(private http:HttpClient) {
    console.log("Servicio Cuentas está corriendo");
  }

  ObtenerDestinos():Observable<any>{
    return this.http.get<any>(url,httpOptions);
  }
}
