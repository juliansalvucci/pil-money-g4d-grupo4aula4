import { Component } from '@angular/core';
import { TarjetaComponent } from './tarjeta/tarjeta.component';
import { MatDialog } from '@angular/material/dialog';

export interface DialogData {
  animal: string;
  name: string;
}

@Component({
  selector: 'app-pago-tarjeta-debito',
  templateUrl: './pago-tarjeta-debito.component.html',
  styleUrls: ['./pago-tarjeta-debito.component.css']
})


export class PagoTarjetaDebitoComponent {

  animal!: string;
  name!: string;

  constructor(public dialog: MatDialog) {}

  openDialog(): void {
    const dialogRef = this.dialog.open(TarjetaComponent, {
      width: '300px',
      height: '600px',
      data: {name: this.name, animal: this.animal}
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
      this.animal = result;
    });
  }

  

}
  


