import { Component } from '@angular/core';
import { FormControl, FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  hide = true;

  
  /*
  loginForm: FormGroup;

  error: boolean = false;
  mensajeError: string = "";
  
  
  
  constructor(private fb: FormBuilder) {
    this.loginForm = this.fb.group({
      'usuario': ['', Validators.required],
      'contraseña': ['', Validators.required]
    });
  }

  login():void {
    if (this.loginForm.invalid) {
      this.error = true;
      this.mensajeError = "Campo requerido"
    }else{
      this.error = false;
      
    }


  }
  */
  

  

}
