import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PagoTarjetaDebitoComponent } from './pago-tarjeta-debito.component';

describe('PagoTarjetaDebitoComponent', () => {
  let component: PagoTarjetaDebitoComponent;
  let fixture: ComponentFixture<PagoTarjetaDebitoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PagoTarjetaDebitoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PagoTarjetaDebitoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
