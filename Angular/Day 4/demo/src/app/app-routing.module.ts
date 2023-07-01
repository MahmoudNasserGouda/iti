import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { WelcomeComponent } from './Components/welcome/welcome.component';
import { ProductListComponent } from './Components/product-list/product-list.component';
import { NotFoundComponent } from './Components/not-found/not-found.component';
import { ProductDetailsComponent } from './Components/product-details/product-details.component';

const routes: Routes = [
  {path:'',redirectTo:'/welcome',pathMatch:'full'},
  {path:'welcome', component: WelcomeComponent},
  {path:'products', component: ProductListComponent},
  {path:'products/:id',component:ProductDetailsComponent},
  {path:'**',component:NotFoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
