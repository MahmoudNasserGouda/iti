import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { IProduct } from 'src/app/Models/iproduct';
import { ProductService } from 'src/app/Services/product.service';

@Component({
  selector: 'app-core',
  templateUrl: './core.component.html',
  styleUrls: ['./core.component.css']
})
export class CoreComponent implements OnInit, OnDestroy {
  sub!:Subscription;
  private _productId : number = 0;
  title: string = "images";
  products: IProduct[] = [];
  errorMessage:string ='';
  product: IProduct = {} as IProduct;
  constructor(private productService:ProductService)
  {
    this.productId = 0;
  }

  public get productId():number
  {
    return this._productId;
  }
  public set productId(value:number)
  {
    this._productId = value;
    //console.log(value);
    this.imageSrc = `https://picsum.photos/id/${this.productId}/600/600`;
  }

  ngOnInit(): void {
    this.sub= this.productService.getProducts().subscribe({
      next : products => {
        this.products = products;
        this.product = this.products[this.productId];
      },
      error : err => this.errorMessage=err
    })
  }
  imageSrc = `https://picsum.photos/id/${this.productId}/600/600`;
  nextImage() {
    this.productId++;
    if (this._productId < this.products.length) {
      this.product = this.products[this.productId];
    }
 }
  prevImage() {
    this.productId--;
    if (this._productId < this.products.length) {
      this.product = this.products[this.productId];
    }
  }

  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }
}
