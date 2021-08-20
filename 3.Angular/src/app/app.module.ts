//MÓDULOS
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MaterialModule } from './material/material.module';
import { AppRoutingModule } from './app-routing.module';
import { ReactiveFormsModule } from '@angular/forms';
import { DepositoModule } from './src/app/deposito/deposito.module';
import { FormsModule } from '@angular/forms';


//COMPONENTES
import { AppComponent } from './app.component';
import { NavbarComponent } from './layout/navbar/navbar.component';
import { LoginComponent } from './auth/login/login.component';
import { RegisterComponent } from './auth/register/register.component';
import { SidebarComponent } from './layout/sidebar/sidebar.component';
import { HeaderComponent } from './layout/header/header.component';
import { FooterComponent } from './layout/footer/footer.component';
import { ExtraccionComponent } from './src/app/extraccion/extraccion.component';
import { HomeComponent } from './src/app/home/home.component';
import { TransferenciaModule } from './src/app/transferencia/transferencia.module';






@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    NavbarComponent,
    LoginComponent,
    RegisterComponent,
    SidebarComponent,
    ExtraccionComponent,
    HomeComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MaterialModule,
    ReactiveFormsModule,
    DepositoModule,
    FormsModule,
    TransferenciaModule
  ],
  
  exports: [DepositoModule],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
