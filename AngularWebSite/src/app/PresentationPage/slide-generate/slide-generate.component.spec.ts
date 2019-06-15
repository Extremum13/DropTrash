import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SlideGenerateComponent } from './slide-generate.component';

describe('SlideGenerateComponent', () => {
  let component: SlideGenerateComponent;
  let fixture: ComponentFixture<SlideGenerateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SlideGenerateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SlideGenerateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
