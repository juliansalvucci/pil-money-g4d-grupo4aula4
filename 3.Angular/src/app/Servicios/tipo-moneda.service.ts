import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { TipoMoneda } from '../Interfaces/TipoMoneda';

const url ="https://localhost:44354/api/TipoMoneda";
const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable({
  providedIn: 'root'
})
export class TipoMonedaService {

  constructor(private http:HttpClient) {
    console.log("Servicio Cuentas está corriendo");
  }

  obtenerTipoMoneda():Observable<TipoMoneda[]>{
    return this.http.get<any>(url,httpOptions);
  }

}
