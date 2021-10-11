import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';

const url ="https://localhost:44354/api/Usuario";
const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};


export class Usuario{
  apellido: string="";
  nombre:   string="";
  correo:   string="";
  dni:      number=0;
  password: string="";
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
