import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OpcionTransferenciaComponent } from './opcion-transferencia.component';

describe('OpcionTransferenciaComponent', () => {
  let component: OpcionTransferenciaComponent;
  let fixture: ComponentFixture<OpcionTransferenciaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OpcionTransferenciaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OpcionTransferenciaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
