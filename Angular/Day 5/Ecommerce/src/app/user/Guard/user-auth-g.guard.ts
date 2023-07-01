import { CanActivateFn, Router } from '@angular/router';
import { UserAuthService } from '../Services/user-auth.service';
import { inject } from '@angular/core';

export const userAuthGGuard: CanActivateFn = (route, state) => {
  const authService=inject(UserAuthService);
  const router = inject(Router);
  if(authService.UserState)
  {
    return true;
  }
  else
  {
    alert('you must log in first');
    router.navigate(['/user/userLogin']);
    return false;
  }

};
