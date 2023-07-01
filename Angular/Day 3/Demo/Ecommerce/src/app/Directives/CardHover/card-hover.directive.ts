import { Directive, ElementRef, HostListener, Input, OnChanges, SimpleChanges } from '@angular/core';

@Directive({
  selector: '[appCardHover]'
})
export class CardHoverDirective implements OnChanges{
  put() borderColorFirst:string='green';
  @Input(@In) borderColorSecond:string='orange';
  @Input() ColorBool : Boolean = false;
  constructor(private el:ElementRef) { }

  ngOnChanges(changes: SimpleChanges): void {
    this.el.nativeElement.style.border= `0px solid ${this.borderColorFirst}`
    this.el.nativeElement.style.height = `7px`;
    this.el.nativeElement.style.width= '7px';
  }
  @HostListener('mouseover') funMouseOver()
  {
    this.el.nativeElement.style.border= `5px solid ${this.borderColorFirst}`
    this.el.nativeElement.style.height = `50px`;
    this.el.nativeElement.style.width= '50px';
  }
  @HostListener('mouseout') funMouseOut()
  {
    this.el.nativeElement.style.border= `3px dashed ${this.borderColorSecond}`
    this.el.nativeElement.style.height = `50px`;
    this.el.nativeElement.style.width= '50px';
  }

}
