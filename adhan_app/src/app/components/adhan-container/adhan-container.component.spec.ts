import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdhanContainerComponent } from './adhan-container.component';

describe('AdhanContainerComponent', () => {
  let component: AdhanContainerComponent;
  let fixture: ComponentFixture<AdhanContainerComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AdhanContainerComponent]
    });
    fixture = TestBed.createComponent(AdhanContainerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
