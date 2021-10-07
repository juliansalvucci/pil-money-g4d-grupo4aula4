import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './layout/home/home.component';
import { SidebarComponent } from './layout/sidebar/sidebar.component';
import { LoginComponent } from './Modulos/auth/login/login.component';
import { RegisterComponent } from './Modulos/auth/register/register.component';
import { CuentaComponent } from './Modulos/cuenta/cuenta/cuenta.component';
import { PagoTarjetaDebitoComponent } from './Modulos/deposito/pago-tarjeta-debito/pago-tarjeta-debito.component';
import { OpcionTransferenciaComponent } from './Modulos/transferencia/opcion-transferencia/opcion-transferencia.component';
import { AuthguardService } from './Servicios/authguard.service';



const routes: Routes = [
  
  {path: 'home', component: HomeComponent},
  {path: 'registro', component: RegisterComponent},
  {path: 'login', component: LoginComponent},
  {path: '', redirectTo: 'home', pathMatch: 'full'},
  
  {path:'escritorio', component: SidebarComponent, canActivate: [AuthguardService],   //Para acceder al home el usuario debe estar logueado.
  children:[
    {path:'cuenta', component: CuentaComponent},
    {path:'transacciones', component: OpcionTransferenciaComponent},
    {path:'deposito', component: PagoTarjetaDebitoComponent},
  ]},
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
