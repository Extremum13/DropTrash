import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistrationWindowComponent } from './registration-window.component';

describe('RegistrationWindowComponent', () => {
  let component: RegistrationWindowComponent;
  let fixture: ComponentFixture<RegistrationWindowComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RegistrationWindowComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RegistrationWindowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
