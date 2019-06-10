import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LinijaDetaljiComponent } from './linija-detalji.component';

describe('LinijaDetaljiComponent', () => {
  let component: LinijaDetaljiComponent;
  let fixture: ComponentFixture<LinijaDetaljiComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LinijaDetaljiComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LinijaDetaljiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
