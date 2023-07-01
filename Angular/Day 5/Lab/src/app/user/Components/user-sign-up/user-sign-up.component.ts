import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { User } from '../../Model/user';

@Component({
  selector: 'app-user-sign-up-temlpate',
  templateUrl: './user-sign-up.component.html',
  styleUrls: ['./user-sign-up.component.css']
})
export class UserSignUpComponent {
  user = new User();

  save(signupForm:NgForm)
  {
    console.log(signupForm.form);
    console.log('Saved signup', JSON.stringify(signupForm.value));
  }
}
