import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserSignUpTemlpateComponent } from './user-sign-up-temlpate.component';

describe('UserSignUpTemlpateComponent', () => {
  let component: UserSignUpTemlpateComponent;
  let fixture: ComponentFixture<UserSignUpTemlpateComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UserSignUpTemlpateComponent]
    });
    fixture = TestBed.createComponent(UserSignUpTemlpateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
