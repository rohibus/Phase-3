import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CompanychartComponent } from './companychart.component';

describe('CompanychartComponent', () => {
  let component: CompanychartComponent;
  let fixture: ComponentFixture<CompanychartComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CompanychartComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CompanychartComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
