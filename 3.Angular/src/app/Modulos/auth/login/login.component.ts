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
        'password': ['', Validators.required]
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
         this.router.navigate(['ruta']);
       },
         error => {
          this.error = error;
         }
       );
   }
  

}
