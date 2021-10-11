import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';

const url ="https://localhost:44339/api/Tarjeta";
const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

export class Tarjeta{
  numero: number=0;
  //fechaVencimiento: Date;
  codigoDeSeguridad: number=0;
  titular: string="";

}

@Injectable({
  providedIn: 'root'
})
export class TarjetaService {

  constructor(private http:HttpClient) {
    console.log("Servicio Cuentas está corriendo");
  }

  ListarTarjetas():Observable<any>{
    return this.http.get<any>(url,httpOptions);
  }
}
