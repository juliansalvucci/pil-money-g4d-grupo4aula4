import { Component, OnInit } from '@angular/core';
import {FormBuilder, FormGroup, Validators, FormControl} from '@angular/forms';
import {STEPPER_GLOBAL_OPTIONS} from '@angular/cdk/stepper';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
  providers: [{
    provide: STEPPER_GLOBAL_OPTIONS, useValue: {showError: true}
  }]
})
export class RegisterComponent implements OnInit {

  hide = true;
  hide1 = true;

  firstFormGroup!: FormGroup;
  secondFormGroup!: FormGroup;

  constructor(private _formBuilder: FormBuilder) { }

  email = new FormControl('', [Validators.required, Validators.email]);

  ngOnInit(){ 
    this.firstFormGroup = this._formBuilder.group({
      apellido: ['', Validators.required],
      nombre: ['', Validators.required],
      dni: ['', Validators.required],
      correo: ['', Validators.required],
    });
    this.secondFormGroup = this._formBuilder.group({
      contraseña: ['', Validators.required],
      validador: ['', Validators.required],
    });
  }

 validarContraseña(){
    //TO DO
  }

  getErrorMessage() {
    return this.email.hasError('email') ? 'Formato de correo inválido' : '';
  }

  enviarPaso1(firstFormGroup:any){
    console.log(firstFormGroup.value)
  }

  enviarPaso2(secondFormGroup:any){
    console.log(secondFormGroup.value)
  }



}
