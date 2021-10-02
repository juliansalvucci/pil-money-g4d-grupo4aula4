import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';

const url ="https://localhost:44339/api/Cuenta";
const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

export class Transferencia{
  id: number=0;
  //fecha: Date;
  //hora: Time;  
  monto: number=0;
  nota: string=""
  cvu: number=0;
  destino: number=0;
}

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
