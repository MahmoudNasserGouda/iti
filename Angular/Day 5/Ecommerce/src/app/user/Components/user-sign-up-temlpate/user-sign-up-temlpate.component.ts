import { Component } from '@angular/core';
import { User } from '../../Models/user';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-user-sign-up-temlpate',
  templateUrl: './user-sign-up-temlpate.component.html',
  styleUrls: ['./user-sign-up-temlpate.component.css']
})
export class UserSignUpTemlpateComponent {
  user = new User();

  save(signupForm:NgForm)
  {
    console.log(signupForm.form);
    console.log('Saved signup', JSON.stringify(signupForm.value));
  }
}
