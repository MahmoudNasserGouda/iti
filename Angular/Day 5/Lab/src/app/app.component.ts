import { Component, OnChanges, SimpleChanges } from '@angular/core';
import { UserAuthService } from './user/Services/user-auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent{
  title = 'day3';
  userState: boolean;
  constructor(private userService: UserAuthService) {
    this.userState = this.userService.UserState;
  }
  getuserState (): boolean {
    return this.userService.UserState;
  }
  Logout (): void {
    this.userService.logout();
  }

}
