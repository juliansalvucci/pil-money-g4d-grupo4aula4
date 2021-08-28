import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable, of, BehaviorSubject, throwError } from 'rxjs';
import { Router } from '@angular/router';
import { catchError, map } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http: HttpClient,private router: Router) { 
    
  }

  login(data: any){

  }
    
  
}
