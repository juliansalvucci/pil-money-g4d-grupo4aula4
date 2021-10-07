import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';

interface Animal {
  name: string;
  sound: string;
}

@Component({
  selector: 'app-opcion-extraccion',
  templateUrl: './opcion-extraccion.component.html',
  styleUrls: ['./opcion-extraccion.component.css']
})
export class OpcionExtraccionComponent {
  animalControl = new FormControl('', Validators.required);
  selectFormControl = new FormControl('', Validators.required);
  animals: Animal[] = [
    {name: 'Dog', sound: 'Woof!'},
    {name: 'Cat', sound: 'Meow!'},
    {name: 'Cow', sound: 'Moo!'},
    {name: 'Fox', sound: 'Wa-pa-pa-pa-pa-pa-pow!'},
  ];OnInit(): void {
  }

}
