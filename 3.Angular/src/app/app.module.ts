//MÓDULOS
import { NgModule } from "@angular/core";
import { MaterialModule } from "./Material/material.module";
import { AuthModule } from "./Modulos/auth/auth.module";
import { HttpClientModule } from "@angular/common/http";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { AppRoutingModule } from "./app-routing.module";
import { CuentaModule } from "./Modulos/cuenta/cuenta.module";
import { DepositoModule } from "./Modulos/deposito/deposito.module";
import { ExtraccionModule } from "./Modulos/extraccion/extraccion.module";
import { TransferenciaModule } from "./Modulos/transferencia/transferencia.module";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";


//COMPONENTES
import { AppComponent } from "./app.component";
import { FooterComponent } from "./layout/footer/footer.component";
import { HeaderComponent } from "./layout/header/header.component";
import { HomeComponent } from "./layout/home/home.component";
import { NavbarComponent } from "./layout/navbar/navbar.component";
import { SidebarComponent } from "./layout/sidebar/sidebar.component";
import { LoginComponent } from "./Modulos/auth/login/login.component";
import { RegisterComponent } from "./Modulos/auth/register/register.component";
import { NotFoundComponent } from "./layout/not-found/not-found.component";

//SERVICIOS
import { AuthService } from "./Servicios/auth.service";








@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    FooterComponent,
    SidebarComponent,
    NavbarComponent,
    HeaderComponent,
    LoginComponent,
    RegisterComponent,
    HomeComponent,
    NotFoundComponent,
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
    CuentaModule,
    BrowserAnimationsModule
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
