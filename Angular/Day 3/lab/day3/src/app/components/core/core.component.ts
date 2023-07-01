import { Component } from '@angular/core';

@Component({
  selector: 'app-core',
  templateUrl: './core.component.html',
  styleUrls: ['./core.component.css']
})
export class CoreComponent {
  constructor()
  {
    this.imageId = 0;
  }
  private _imageId : number = 0;
  title: string = "images";
  public get imageId():number
  {
    return this._imageId;
  }
  public set imageId(value:number)
  {
    this._imageId = value;
    //console.log(value);
    this.getImage();
  }
  getImage()
  {
    this.imageSrc = `https://picsum.photos/id/${this.imageId}/600/600`;
  }
  imageSrc = `https://picsum.photos/id/${this.imageId}/600/600`;
  nextImage() {
    this.imageId++;
    this.getImage();
 }
  prevImage() {
    this.imageId--;
    this.getImage();
  }
}
