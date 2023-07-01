import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserLoginReactiveFormsComponent } from './user-login-reactive-forms.component';

describe('UserLoginReactiveFormsComponent', () => {
  let component: UserLoginReactiveFormsComponent;
  let fixture: ComponentFixture<UserLoginReactiveFormsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UserLoginReactiveFormsComponent]
    });
    fixture = TestBed.createComponent(UserLoginReactiveFormsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
