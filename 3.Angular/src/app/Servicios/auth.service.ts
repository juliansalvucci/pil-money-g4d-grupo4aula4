import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http'
import { Observable, of, BehaviorSubject, throwError } from 'rxjs';
import { Router } from '@angular/router';
import { catchError, map } from 'rxjs/operators';
import {Usuario, UsuarioService } from './usuario.service';
import { Login } from '../Interfaces/Login';

const url ="https://localhost:44354/api/Login/authenticate";
const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  loggedIn= new BehaviorSubject<boolean>(false);
  currentUserSubject: BehaviorSubject<Login>;
  currentUser: Observable<Login>;
  constructor(private http:HttpClient) {
    console.log("Servicio de Atuenticación está corriendo");
    this.currentUserSubject = new BehaviorSubject<Login>(JSON.parse(localStorage.getItem('currentUser') || '{}'));
    this.currentUser = this.currentUserSubject.asObservable();
  }

  login(login: Login): Observable<any> {  
    return this.http.post<any>(url,login , httpOptions)
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

  get usuarioAutenticado(): Login {
    return this.currentUserSubject.value;
  }

  get estaAutenticado(): Observable<boolean> {
   
    return this.loggedIn.asObservable();
    
  }
  

}
