import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TablaDepositoComponent } from './tabla-deposito.component';

describe('TablaDepositoComponent', () => {
  let component: TablaDepositoComponent;
  let fixture: ComponentFixture<TablaDepositoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TablaDepositoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TablaDepositoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
