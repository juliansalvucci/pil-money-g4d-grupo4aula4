import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CuentaComponent } from './cuenta/cuenta.component';
import { SidebarComponent } from 'src/app/layout/sidebar/sidebar.component';
import { MaterialModule } from 'src/app/material/material.module';




@NgModule({
  declarations: [
    CuentaComponent,
    SidebarComponent
  ],
  imports: [
    CommonModule,
    MaterialModule
  ],
  exports: [
    CuentaComponent,
    SidebarComponent
  ]
})
export class CuentaModule { }
