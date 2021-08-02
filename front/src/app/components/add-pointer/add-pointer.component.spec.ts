import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddPointerComponent } from './add-pointer.component';

describe('AddPointerComponent', () => {
  let component: AddPointerComponent;
  let fixture: ComponentFixture<AddPointerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddPointerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddPointerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
