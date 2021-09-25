import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';

const url ="https://localhost:44339/api/Usuario";
const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

export class Usuario{
  id: number=0;
  apellido: string="";
  nombre: string="";
  pass: string="";
  correo: string="";
  dni: number=0;
  fotoFrenteDni: string="";
  fotoDorsoDni: string="";
  token?: string;
}

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  constructor(private http:HttpClient) {
    console.log("Servicio Usuarios está corriendo");
   }

  registrarUsuario(usuario:Usuario):Observable<Usuario>{
    return this.http.post<Usuario>(url, usuario, httpOptions);
  }
}
