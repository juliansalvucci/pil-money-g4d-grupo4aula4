import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './auth/login/login.component';
import { RegisterComponent } from './auth/register/register.component';
import { NotFoundComponent } from './layout/not-found/not-found.component';
import { SidebarComponent } from './layout/sidebar/sidebar.component';
import { CuentaComponent } from './src/app/cuenta/cuenta/cuenta.component';
import { PagoTarjetaDebitoComponent } from './src/app/deposito/pago-tarjeta-debito/pago-tarjeta-debito.component';
import { HomeComponent } from './src/app/home/home.component';
import { AuthguardService } from './src/app/servicios/authguard.service';
import { OpcionTransferenciaComponent } from './src/app/transferencia/opcion-transferencia/opcion-transferencia.component';


const routes: Routes = [
  {path: 'home', component: HomeComponent},
  {path: 'registro', component: RegisterComponent},
  {path: 'login', component: LoginComponent},
  {path:'escritorio', component: SidebarComponent, canActivate: [AuthguardService],  //Para acceder al home el usuario debe estar logueado.
  children:[
    {path:'cuenta', component: CuentaComponent},
    {path:'deposito', component: PagoTarjetaDebitoComponent},
    {path:'transferencia', component: OpcionTransferenciaComponent}, 
  ]},
  {path: '', redirectTo: 'home', pathMatch: 'full'},
  { path: "**", component: NotFoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
