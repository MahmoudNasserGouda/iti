import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { CoreComponent } from './components/core/core.component';
import { ConverBorderPipe } from './shared/pipe/conver-border.pipe';
import { ImageHoverDirective } from './directives/image-hover.directive';

@NgModule({
  declarations: [
    AppComponent,
    CoreComponent,
    ConverBorderPipe,
    ImageHoverDirective
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
