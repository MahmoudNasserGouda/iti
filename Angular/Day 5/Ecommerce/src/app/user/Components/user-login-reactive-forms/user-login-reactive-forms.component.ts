import { Component } from '@angular/core';
import { User } from '../../Models/user';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-user-login-reactive-forms',
  templateUrl: './user-login-reactive-forms.component.html',
  styleUrls: ['./user-login-reactive-forms.component.css']
})
export class UserLoginReactiveFormsComponent {
user = new User();
userForm: FormGroup;
constructor(private fb:FormBuilder)
{
// this.userForm = new FormGroup({
//   firstName : new FormControl('',[Validators.required, Validators.minLength(4)]),
//   lastName : new FormControl('',[Validators.required]),
//   email : new FormControl('',[Validators.required, Validators.email])
// })
this.userForm = this.fb.group({
firstName : ['',[Validators.required, Validators.minLength(4)]],
lastName : ['',[Validators.required, Validators.minLength(4)]],
email : ['',[Validators.required, Validators.email]]
});

}

get firstName()
{
  return this.userForm.get('firstName');
}
}
