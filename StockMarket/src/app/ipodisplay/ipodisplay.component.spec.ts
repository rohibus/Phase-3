import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { IPOdisplayComponent } from './ipodisplay.component';

describe('IPOdisplayComponent', () => {
  let component: IPOdisplayComponent;
  let fixture: ComponentFixture<IPOdisplayComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ IPOdisplayComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(IPOdisplayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
