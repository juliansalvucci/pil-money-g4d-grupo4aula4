//MÓDULOS
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MaterialModule } from './material/material.module';
import { AppRoutingModule } from './app-routing.module';
import { ReactiveFormsModule } from '@angular/forms';
import { DepositoModule } from './src/app/deposito/deposito.module';
import { FormsModule } from '@angular/forms';
import { TransferenciaModule } from './src/app/transferencia/transferencia.module';
import { AuthModule } from './auth/auth.module';
import { HttpClientModule } from '@angular/common/http';
import { ExtraccionModule } from './src/app/extraccion/extraccion.module';
import { CuentaModule } from './src/app/cuenta/cuenta.module';

//COMPONENTES
import { AppComponent } from './app.component';
import { NavbarComponent } from './layout/navbar/navbar.component';
import { LoginComponent } from './auth/login/login.component';
import { RegisterComponent } from './auth/register/register.component';
import { HeaderComponent } from './layout/header/header.component';
import { FooterComponent } from './layout/footer/footer.component';
import { HomeComponent } from './src/app/home/home.component';

//SERVICIOS
import { AuthService } from './src/app/servicios/auth.service';






@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    NavbarComponent,
    LoginComponent,
    RegisterComponent,
    HomeComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MaterialModule,
    ReactiveFormsModule,
    DepositoModule,
    ExtraccionModule,
    FormsModule,
    TransferenciaModule, 
    AuthModule,
    HttpClientModule,
    CuentaModule
  ],
  
  exports: [
    DepositoModule,
    TransferenciaModule,
    AuthModule
  ],
  providers: [
    AuthService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
