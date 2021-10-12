import { Component } from '@angular/core';
import { FormControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { observable } from 'rxjs';
import { Router } from '@angular/router';
import { Usuario } from 'src/app/Servicios/usuario.service';
import { AuthService } from 'src/app/Servicios/auth.service';



@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  hide = true;

  /*
  correo = new FormControl('', [Validators.required, Validators.email]);
  password = new FormControl('', [Validators.required]);

  getErrorMessage() {
    if (this.correo.hasError('required')) {
      return 'Formato de correo inválido';
    }

    return this.email.hasError('email') ? 'Not a valid email' : '';
  }

  getErrorPass() {
    if (this.password.hasError('required')) {
      return 'La contraseña debe tener mínimamente 8 caracteres';
    }

    return this.password.hasError('email') ? 'Not a valid email' : '';
  }
  */
  
  usuario = new Usuario(); 
  [x: string]: any;
  //returnUrl: string;
   loginForm:FormGroup;
   constructor(private formBuilder: FormBuilder,
     private authService: AuthService,
     private router: Router) {
     this.loginForm= this.formBuilder.group(
       {
        'correo': ['', [Validators.required, Validators.email]] ,
        'password': ['',[Validators.required, Validators.minLength(8)]]
       }
     )
    }
   get Pass()
   {
     return this.loginForm.get("password");
   }
   get Correo()
   {
    return this.loginForm.get("correo");
   }
   /*
   get PasswordValid()
   {
     return this.Password?.touched && !this.Password?.valid;
   }
   get MailValid()
   {
     return this.Mail?.touched && !this.Mail?.valid;
   }   

   */
   ngOnInit(): void {
     this.returnUrl = this.route.snapshot.queryParams.returnUrl || '/';
   }
   
   
   onEnviar(event: Event, usuario:Usuario): void {
     console.log(usuario)
     event.preventDefault();
     this.authService.login(usuario)
       .subscribe(
         data => {
         console.log("DATA"+ JSON.stringify( data));   
         this.router.navigate(['/escritorio']);
       },
         error => {
          this.error = error;
         }
       );
   }
  

}
