import { Component } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  hide = true;

  loginForm: FormGroup; //contiene reglas del formulario

  constructor(private fb: FormBuilder) {
    this.loginForm = this.fb.group({
      'usuario': ['', Validators.required],
      'contraseña': ['', Validators.required]
    });
  }

  enviar(loginForm:any){
    console.log(loginForm.value)
  } 
  /*nota*/
}
