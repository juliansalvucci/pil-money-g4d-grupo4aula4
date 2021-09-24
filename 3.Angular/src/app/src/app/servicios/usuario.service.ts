import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';


export class Usuario{
  id: number=0;
  apellido: string="";
  nombre: string="";
  pass: string="";
  correo: string="";
  dni: number=0;
  fotoFrenteDni: number=0;
  fotoDorsoDni: number=0;
  token?: string;
}

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  constructor() { }
}
