import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductListComponent } from './Components/product-list/product-list.component';
import { FormsModule } from '@angular/forms';
import { ConverSpacePipe } from './Shared/Pipe/conver-space.pipe';
import { FontColorDirective } from './Directives/FontColor/font-color.directive';
import { CardHoverDirective } from './Directives/CardHover/card-hover.directive';


@NgModule({
  declarations: [
    AppComponent,
    ProductListComponent,
    ConverSpacePipe,
    FontColorDirective,
    CardHoverDirective

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
