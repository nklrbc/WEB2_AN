import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MenjajCenovnikComponent } from './menjaj-cenovnik.component';

describe('MenjajCenovnikComponent', () => {
  let component: MenjajCenovnikComponent;
  let fixture: ComponentFixture<MenjajCenovnikComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MenjajCenovnikComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MenjajCenovnikComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
