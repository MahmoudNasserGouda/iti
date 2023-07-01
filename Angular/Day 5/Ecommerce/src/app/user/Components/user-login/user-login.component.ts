import { Component, OnInit } from '@angular/core';
import { UserAuthService } from '../../Services/user-auth.service';

@Component({
  selector: 'app-user-login',
  templateUrl: './user-login.component.html',
  styleUrls: ['./user-login.component.css']
})
export class UserLoginComponent implements OnInit {
  user:boolean = false;
constructor(private userService: UserAuthService)
{

}
  ngOnInit(): void {
    this.user = this.userService.UserState;
  }
  userLogin()
  {
    this.userService.login('static@gmail.com','1234');
    this.user = this.userService.UserState;
  }
  userLogOut()
  {
    this.userService.logout();
    this.user = this.userService.UserState;
  }
}
