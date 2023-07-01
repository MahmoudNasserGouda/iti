import {Component} from "@angular/core";

@Component( {
  selector: 'app-root',
  // template: `<div>
  //   <h1>My First App {{pageTitle}} </h1>
  //   <h2>{{printName("Mostafa")}}</h2>
  // </div>`
  templateUrl:'./app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent
{
  pageTitle:string = 'Ecommerce Application';
  printName(name:string):string
  {
    return "Developer by " + name;
  }
}
