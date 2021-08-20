import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Deposito } from '../Interfaces/interfaces.interfaces';


const apiUrl = 'http://localhost:numero/api/nombreApi';

@Injectable({
  providedIn: 'root'
})
export class DepositoService {
  /*
  constructor(private http: HttpClient) { }

  getAll(): Observable<Deposito> {
    return this.http.get(apiUrl);
  }

  get(id: number): Observable<Deposito> {
    return this.http.get(`${apiUrl}/${id}`);
  }

  create(data: any): Observable<Deposito> {  //en lugar de any, va una interface
    return this.http.post(apiUrl, data);
  }
  */
}
