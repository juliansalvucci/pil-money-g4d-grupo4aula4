import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http'
import { Observable, of, BehaviorSubject, throwError } from 'rxjs';
import { Router } from '@angular/router';
import { catchError, map } from 'rxjs/operators';
import {Usuario, UsuarioService } from './usuario.service';

const url ="https://localhost:44339/api/login/authenticate";
const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  loggedIn= new BehaviorSubject<boolean>(false);
  currentUserSubject: BehaviorSubject<Usuario>;
  currentUser: Observable<Usuario>;
  constructor(private http:HttpClient) {
    console.log("Servicio de Atuenticación está corriendo");
    this.currentUserSubject = new BehaviorSubject<Usuario>(JSON.parse(localStorage.getItem('currentUser') || '{}'));
    this.currentUser = this.currentUserSubject.asObservable();
   }

  login(usuario: Usuario): Observable<any> {  
    return this.http.post<any>(url, usuario, httpOptions)
      .pipe(map(data => {
        localStorage.setItem('currentUser', JSON.stringify(data ));
        this.currentUserSubject.next(data);
        this.loggedIn.next(true);
        console.log(data);   
        
        return data;
      }));
  }

  logout(): void{
    localStorage.removeItem('currentUser');
    this.loggedIn.next(false);
    
  }

  get usuarioAutenticado(): Usuario {
    return this.currentUserSubject.value;
  }

  get estaAutenticado(): Observable<boolean> {
   
    return this.loggedIn.asObservable();
  }
  
}
