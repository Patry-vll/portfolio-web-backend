import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RetoLogoComponent } from './reto-logo.component';

describe('RetoLogoComponent', () => {
  let component: RetoLogoComponent;
  let fixture: ComponentFixture<RetoLogoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RetoLogoComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RetoLogoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
