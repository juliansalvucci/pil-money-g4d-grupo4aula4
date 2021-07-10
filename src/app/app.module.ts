import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { NavbarComponent } from './layout/navbar/navbar.component';
import { LoginComponent } from './auth/login/login.component';
import { RegisterComponent } from './auth/register/register.component';
import { SidebarComponent } from './layout/sidebar/sidebar.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatFormFieldModule} from '@angular/material/form-field';
import { HeaderComponent } from './layout/header/header.component';
import { FooterComponent } from './layout/footer/footer.component';
import {MatIconModule} from '@angular/material/icon';
<<<<<<< HEAD
import { DepositoComponent } from './src/app/deposito/deposito.component';
import { ExtraccionComponent } from './src/app/extraccion/extraccion.component';
=======
import { NombrecomponenteComponent } from './src/app/nombrecomponente/nombrecomponente.component';
import { TransferenciaComponent } from './src/app/transferencia/transferencia.component';
>>>>>>> 5d8b471c60f234b5a785bae5465f30af057b2b13


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    NavbarComponent,
    LoginComponent,
    RegisterComponent,
    SidebarComponent,
<<<<<<< HEAD
    DepositoComponent,
    ExtraccionComponent,
=======
    NombrecomponenteComponent,
    TransferenciaComponent,
>>>>>>> 5d8b471c60f234b5a785bae5465f30af057b2b13

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatFormFieldModule,
    MatIconModule
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
