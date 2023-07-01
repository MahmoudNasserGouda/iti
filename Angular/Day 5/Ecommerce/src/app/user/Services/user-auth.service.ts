import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserAuthService {
  //Bahavior Subject
  private isUserLoggedSubject:BehaviorSubject<boolean>;

  constructor() {
    this.isUserLoggedSubject = new BehaviorSubject<boolean>(this.UserState);
   }

   get UserState():boolean
   {
    return (localStorage.getItem('token'))? true : false;
   }

   getUserState():Observable<boolean>
   {
    return this.isUserLoggedSubject.asObservable();
   }

   login(email:string, password:string)
   {
    let userToken='233434';
    localStorage.setItem('token',userToken);
    this.isUserLoggedSubject.next(true);
   }

   logout()
   {
    localStorage.removeItem('token');
    this.isUserLoggedSubject.next(false);
   }
}
