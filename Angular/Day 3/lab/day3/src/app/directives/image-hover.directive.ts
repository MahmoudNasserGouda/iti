import { Directive, ElementRef, HostListener, Input, OnInit, SimpleChanges } from '@angular/core';

@Directive({
  selector: '[appImageHover]'
})
export class ImageHoverDirective implements OnInit {

  @Input() borderColor1:string='blue';
  @Input() borderColor2:string='green';
  @Input() ColorBool : Boolean = false;
  constructor(private el:ElementRef) { }
  ngOnInit(): void {
    this.el.nativeElement.style.border= 'none';
  }

  @HostListener('mouseover') funMouseOver()
  {
    this.el.nativeElement.style.border= `5px solid ${this.borderColor1}`
  }
  @HostListener('mouseout') funMouseOut()
  {
    this.el.nativeElement.style.border= `5px solid ${this.borderColor2}`;
  }
}
