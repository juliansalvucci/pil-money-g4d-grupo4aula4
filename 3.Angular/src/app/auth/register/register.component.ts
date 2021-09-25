import { Component, OnInit } from '@angular/core';
import {FormBuilder, FormGroup, Validators, FormControl} from '@angular/forms';
import { Router } from '@angular/router';
import { Usuario, UsuarioService } from 'src/app/src/app/servicios/usuario.service';


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
})
export class RegisterComponent implements OnInit {
  [x: string]: any;

  hide = true;
  
  usuario = new Usuario(); 
  registerForm!: FormGroup;
 

  constructor(private _formBuilder: FormBuilder,
    private usuarioService: UsuarioService,
    private router: Router) { }

  email = new FormControl('', [Validators.required, Validators.email]);

  ngOnInit(){ 
    this.registerForm = this._formBuilder.group({
      apellido: ['', Validators.required],
      nombre: ['', Validators.required],
      dni: ['', Validators.required],
      correo: ['', Validators.required],
      pass: ['', Validators.required]
    });
  
  }

 

  getErrorMessage() {
    return this.email.hasError('email') ? 'Formato de correo inválido' : '';
  }

  onEnviar(event: Event, usuario:Usuario): void {
    console.log(usuario)
    event.preventDefault();
    this.usuarioService.registrarUsuario(usuario)
      .subscribe(
        (data: any) => {
        console.log("DATA"+ JSON.stringify( data));   
        this.router.navigate(['ruta']);
      },
        (error: any) => {
         this.error = error;
        }
      );
  }

 



}
