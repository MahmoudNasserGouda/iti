import { Component, OnInit } from '@angular/core';
import { UserAuthService } from '../../Services/user-auth.service';
import { User } from '../../Model/user';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-user-login',
  templateUrl: './user-login.component.html',
  styleUrls: ['./user-login.component.css']
})
export class UserLoginComponent implements OnInit {
  userState:boolean = false;
  user = new User();
  userForm: FormGroup;
  constructor(private userService: UserAuthService, private fb: FormBuilder)
  {
    this.userForm = this.fb.group({
      username: ['', [Validators.required]],
      password: ['', [Validators.required, Validators.minLength(6)]]
    });
  }
  ngOnInit(): void {
    this.userState = this.userService.UserState;
  }
  userLogin()
  {
    if(this.username?.valid && this.password?.valid){
      this.userService.login(this.username?.value,this.password?.value);
    }
    this.userState = this.userService.UserState;
    
  }
  get username() {
    return this.userForm.get('username');
  }
  get password() {
    return this.userForm.get('password');
  }
}
