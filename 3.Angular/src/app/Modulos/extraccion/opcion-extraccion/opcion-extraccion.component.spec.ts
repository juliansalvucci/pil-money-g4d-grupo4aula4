import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OpcionExtraccionComponent } from './opcion-extraccion.component';

describe('OpcionExtraccionComponent', () => {
  let component: OpcionExtraccionComponent;
  let fixture: ComponentFixture<OpcionExtraccionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OpcionExtraccionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OpcionExtraccionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
