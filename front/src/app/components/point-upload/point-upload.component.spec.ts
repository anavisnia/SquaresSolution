import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PointUploadComponent } from './point-upload.component';

describe('PointUploadComponent', () => {
  let component: PointUploadComponent;
  let fixture: ComponentFixture<PointUploadComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PointUploadComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PointUploadComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
