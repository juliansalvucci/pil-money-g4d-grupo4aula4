import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { NavbarComponent } from './layout/navbar/navbar.component';
import { LoginComponent } from './auth/login/login.component';
import { RegisterComponent } from './auth/register/register.component';
import { SidebarComponent } from './layout/sidebar/sidebar.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { HeaderComponent } from './layout/header/header.component';
import { FooterComponent } from './layout/footer/footer.component';
import {MatIconModule} from '@angular/material/icon';
import { DepositoComponent } from './src/app/deposito/deposito.component';
import { ExtraccionComponent } from './src/app/extraccion/extraccion.component';
import { TransferenciaComponent } from './src/app/transferencia/transferencia.component';
import {MatFormFieldModule} from '@angular/material/form-field';



@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    NavbarComponent,
    LoginComponent,
    RegisterComponent,
    SidebarComponent,
    DepositoComponent,
    ExtraccionComponent,
    TransferenciaComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatIconModule,
    MatFormFieldModule
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
