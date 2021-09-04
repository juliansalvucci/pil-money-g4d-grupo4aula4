import { Component } from '@angular/core';
import { FormControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthService } from 'src/app/src/app/servicios/auth.service';
import { observable } from 'rxjs';


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
  /*
  login(): void {
    if (this.loginForm.invalid) {
      this.error = true;
      this.mensajeError = "¡Los campos no pueden estar vacíos!";
    }
    else {
      this.error = false;
      this.cargando = true;
      this.authService.login(this.loginForm.value).subscribe(r => {
      this.cargando = false;
      this.error = false;
      //(r);
        if (r) {
          if (r.error) {
            this.error = true;
            this.mensajeError = r.msg;
          }
          else
          {
            window.location.reload();
          }
        }
        else {
          this.cargando = false;
          this.error = true;
          this.mensajeError = 'Se produjo un error.';
        }
      },
      )
    }
  }
  */


}
