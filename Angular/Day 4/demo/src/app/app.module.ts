import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductListComponent } from './Components/product-list/product-list.component';
import { FormsModule } from '@angular/forms';
import { ConverSpacePipe } from './Shared/Pipe/conver-space.pipe';
import { FontColorDirective } from './Directives/FontColor/font-color.directive';
import { CardHoverDirective } from './Directives/CardHover/card-hover.directive';
import { StarComponent } from './Components/star/star.component';
import { WelcomeComponent } from './Components/welcome/welcome.component';
import { NotFoundComponent } from './Components/not-found/not-found.component';
import { ProductDetailsComponent } from './Components/product-details/product-details.component';
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [
    AppComponent,
    ProductListComponent,
    ConverSpacePipe,
    FontColorDirective,
    CardHoverDirective,
    StarComponent,
    WelcomeComponent,
    NotFoundComponent,
    ProductDetailsComponent

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
