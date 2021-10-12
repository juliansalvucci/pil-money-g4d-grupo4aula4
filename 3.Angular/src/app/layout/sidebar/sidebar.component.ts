import { Component, OnInit, ViewChild } from '@angular/core';
import { BreakpointObserver } from '@angular/cdk/layout';
import { MatSidenav } from '@angular/material/sidenav';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from 'src/app/Servicios/auth.service';

 
@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent {
  @ViewChild(MatSidenav)
  sidenav!: MatSidenav;

  estaAutenticado:boolean=false;

  constructor(private observer: BreakpointObserver, private route: ActivatedRoute, private authService: AuthService, private router: Router) {
    
  }


  ngAfterViewInit() {
    this.observer.observe(['(max-width: 1500px)']).subscribe((res) => {
      if (res.matches) {
        this.sidenav.mode = 'over';
        this.sidenav.close();
      } else {
        this.sidenav.mode = 'side';
        this.sidenav.open();
      }
    });
  }

  cerrarSesion(){
    this.authService.logout();
    this.estaAutenticado=false;
    this.router.navigate(['/home']);
  }
}