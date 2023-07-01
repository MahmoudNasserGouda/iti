import { Component, EventEmitter, Input, OnChanges, Output, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-star',
  templateUrl: './Rating.component.html',
  styleUrls: ['./Rating.component.css']
})
export class RatingComponent implements OnChanges {
cropWidth:number = 75;
@Input () rating :number =0;

ngOnChanges(changes: SimpleChanges): void {
  this.cropWidth= this.rating*75/5;
}
onClick()
{
  console.log(this.rating);
  this.ratingClicked.emit(`the raing value = ${this.rating}`);
}
@Output() ratingClicked: EventEmitter<string>=new EventEmitter<string>();
}
