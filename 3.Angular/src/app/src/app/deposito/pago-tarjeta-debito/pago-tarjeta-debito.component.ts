import { Component } from '@angular/core';
import { TarjetaComponent } from './tarjeta/tarjeta.component';
import { MatDialog } from '@angular/material/dialog';
import { FormControl, Validators } from '@angular/forms';


interface Animal {
  name: string;
  sound: string;
}

@Component({
  selector: 'app-pago-tarjeta-debito',
  templateUrl: './pago-tarjeta-debito.component.html',
  styleUrls: ['./pago-tarjeta-debito.component.css']
})


export class PagoTarjetaDebitoComponent {
  animalControl = new FormControl('', Validators.required);
  selectFormControl = new FormControl('', Validators.required);
  animals: Animal[] = [
    {name: 'Dog', sound: 'Woof!'},
    {name: 'Cat', sound: 'Meow!'},
    {name: 'Cow', sound: 'Moo!'},
    {name: 'Fox', sound: 'Wa-pa-pa-pa-pa-pa-pow!'},
  ];
}
  


