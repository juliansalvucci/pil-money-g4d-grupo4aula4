import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TablaTransferenciaComponent } from './tabla-transferencia.component';

describe('TablaTransferenciaComponent', () => {
  let component: TablaTransferenciaComponent;
  let fixture: ComponentFixture<TablaTransferenciaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TablaTransferenciaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TablaTransferenciaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
