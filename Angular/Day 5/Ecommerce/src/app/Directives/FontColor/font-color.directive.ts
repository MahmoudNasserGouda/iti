import { Directive, ElementRef, HostListener, Input, OnChanges, OnDestroy, OnInit, SimpleChanges } from '@angular/core';

@Directive({
  selector: '[appFontColor]'
})
export class FontColorDirective implements OnInit, OnChanges, OnDestroy {
  @Input() Uppercase: string="";
  @Input() lowercase: string="";
  @Input() colorDirective: string ="";
  constructor(private el : ElementRef) { }
  //oninit
  ngOnInit(): void {
    console.log("on init");

  }
  ngOnChanges(changes: SimpleChanges): void {
    this.el.nativeElement.style.textTranform = `${this.lowercase}`;
    console.log("On Changes");

  }
  @HostListener('mouseover') funMouserOver()
  {
    this.el.nativeElement.style.textTranform =`${this.Uppercase}`;
    this.el.nativeElement.style.fontSize = '35px';
    this.el.nativeElement.style.color = `${this.colorDirective}`;
  }
  @HostListener('mouseout') funMouserOut()
  {
    this.el.nativeElement.style.textTranform =`${this.lowercase}`;
    this.el.nativeElement.style.fontSize = '15px';
    this.el.nativeElement.style.color = `black`;
  }
  ngOnDestroy(): void {
    console.log('Destroy');

  }
}
