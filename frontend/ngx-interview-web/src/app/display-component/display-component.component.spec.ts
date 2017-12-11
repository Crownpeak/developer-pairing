import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DisplayComponentComponent } from './display-component.component';

describe('DisplayComponentComponent', () => {
  let component: DisplayComponentComponent;
  let fixture: ComponentFixture<DisplayComponentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DisplayComponentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DisplayComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
