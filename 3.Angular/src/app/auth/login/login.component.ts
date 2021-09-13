import { Component } from '@angular/core';
import { FormControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthService } from 'src/app/src/app/servicios/auth.service';
import { observable } from 'rxjs';
import { Router } from '@angular/router';
import { Usuario, UsuarioService } from 'src/app/src/app/servicios/usuario.service';



@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  hide = true;

   
  
  usuario = new Usuario(); 
  [x: string]: any;
  //returnUrl: string;
   loginForm:FormGroup;
   constructor(private formBuilder: FormBuilder,
     private authService: AuthService,
     private router: Router) {
     this.loginForm= this.formBuilder.group(
       {
        'correo': ['', Validators.required],
        'contraseña': ['', [Validators.required, Validators.minLength(8)]]
       }
     )
    }
   get Contraseña()
   {
     return this.loginForm.get("contraseña");
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

 
   ngOnInit(): void {
     this.returnUrl = this.route.snapshot.queryParams.returnUrl || '/';
   }
   */
   
   onEnviar(event: Event, usuario:Usuario): void {
     
     event.preventDefault;
     this.authService.login(this.usuario)
       .subscribe(
         data => {
         console.log("DATA"+ JSON.stringify( data));   
         this.router.navigate(['ruta']);
       },
         error => {
          this.error = error;
         }
       );
   }
  

}
