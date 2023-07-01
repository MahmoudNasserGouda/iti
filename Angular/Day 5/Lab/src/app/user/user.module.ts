import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { userAuthGGuard } from './Guard/user-auth-g.guard';
import { UserProfileComponent } from './Components/user-profile/user-profile.component';
import { UserLoginComponent } from './Components/user-login/user-login.component';
import { UserSignUpComponent } from './Components/user-sign-up/user-sign-up.component';

const routes:Routes =
[
  {path:'userProfile',component: UserProfileComponent,title: 'User Profile',
  canActivate: [userAuthGGuard]},

  {path:'userLogin',component: UserLoginComponent,title: 'User Login'},
  {path:'userSignup',component: UserSignUpComponent,title: 'User Sign Up'},


];

@NgModule({
  declarations: [
    UserProfileComponent,
    UserLoginComponent,
    UserSignUpComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forChild(routes)
  ]
})
export class UserModule { }
