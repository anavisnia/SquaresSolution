import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PointersviewComponent } from './pointersview.component';

describe('PointersviewComponent', () => {
  let component: PointersviewComponent;
  let fixture: ComponentFixture<PointersviewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PointersviewComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PointersviewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
