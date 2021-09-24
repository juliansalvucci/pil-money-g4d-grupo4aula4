import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './auth/login/login.component';
import { RegisterComponent } from './auth/register/register.component';
import { SidebarComponent } from './layout/sidebar/sidebar.component';
import { HomeComponent } from './src/app/home/home.component';


//import { AuthGuard } from '.src/app/servicios/auth.guard';


const routes: Routes = [
  {path: 'home', component: HomeComponent},
  {path: 'registro', component: RegisterComponent},
  {path: 'login', component: LoginComponent},
  {path: '', redirectTo: 'home', pathMatch: 'full'},
  /*
  {path:'escritorio', component: SidebarComponent, canActivate: [AuthGuard],   //Para acceder al home el usuario debe estar logueado.
  children:[
    {path:'cuenta', component: cuentaComponent},
    {path:'transacciones', component: TransferenciaComponent},
    {path:'criptomoneda', component: DepositoComponent},
  ]},
  */
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
