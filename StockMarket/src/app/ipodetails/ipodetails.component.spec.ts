import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { IPOdetailsComponent } from './ipodetails.component';

describe('IPOdetailsComponent', () => {
  let component: IPOdetailsComponent;
  let fixture: ComponentFixture<IPOdetailsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ IPOdetailsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(IPOdetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
