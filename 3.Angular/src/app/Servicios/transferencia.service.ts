import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Transferencia } from '../Interfaces/Transferencia';

const url ="https://localhost:44354/api/Transferencia";
const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};


@Injectable({
  providedIn: 'root'
})
export class TransferenciaService {

  constructor(private http:HttpClient) {
    console.log("Servicio Cuentas está corriendo");
  }

  Transferir(transferencia: Transferencia):Observable<Transferencia>{
    return this.http.post<Transferencia>(url, transferencia, httpOptions);
  }

  listarTransferencias():Observable<any>{
    return this.http.get<any>(url,httpOptions);
  }
}
