import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserProfileComponent } from './Components/user-profile/user-profile.component';
import { RouterModule, Routes } from '@angular/router';
import { userAuthGGuard } from './Guard/user-auth-g.guard';
import { UserLoginComponent } from './Components/user-login/user-login.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { UserSignUpTemlpateComponent } from './Components/user-sign-up-temlpate/user-sign-up-temlpate.component';
import { UserLoginReactiveFormsComponent } from './Components/user-login-reactive-forms/user-login-reactive-forms.component';

const routes:Routes =
[
  {path:'userProfile',component: UserProfileComponent,title: 'User Profile',
  canActivate: [userAuthGGuard]},

  {path:'userLogin',component: UserLoginComponent,title: 'User Login'},
  {path:'userSignUpTemplate',component: UserSignUpTemlpateComponent,title: 'User sign up'},
  {path:'userSignUpRecForms',component: UserLoginReactiveFormsComponent,title: 'User login rec'},


];

@NgModule({
  declarations: [
    UserProfileComponent,
    UserLoginComponent,
    UserSignUpTemlpateComponent,
    UserLoginReactiveFormsComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forChild(routes)
  ]
})
export class UserModule { }
