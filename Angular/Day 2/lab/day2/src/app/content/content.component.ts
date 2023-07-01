import { Component } from '@angular/core';

@Component({
  selector: 'app-content',
  template: '<h1>{{print()}}</h1><div *ngIf="true"><div *ngFor="let x of numbers"><h2>{{x}}</h2></div></div>',
  styleUrls: ['./content.component.css']
})
export class ContentComponent {
    numbers:number[] = [0,1,2,3,4,5,6,7,8,9,10,11,12];
    print (): string {
        return "Hello, Mahmoud!....";
    }
}
