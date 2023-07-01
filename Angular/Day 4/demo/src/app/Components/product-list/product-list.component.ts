import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { IProduct } from 'src/app/Models/iproduct';
import { ProductService } from 'src/app/Services/product.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit, OnDestroy {
  pageTitle:string = 'Product List';
  showImage:boolean = false;
  filterProducts:IProduct[] = [];
  imgWidth:number =60;
  imgMargin:number =2;
  products:IProduct[] =  [];

  errorMessage:string ='';
  sub!:Subscription;// ! assertion operator not null
  constructor(private productService:ProductService)
  {
    this.listFilter = '';
  }

  ngOnInit(): void {
    this.sub= this.productService.getProducts().subscribe({
      next : products => {
        this.products = products;
        this.filterProducts = this.products;
      },
      error : err => this.errorMessage=err
    })
  }
  private _listFilter : string ='';
  public get listFilter():string
  {
    return this._listFilter;
  }
  public set listFilter(value:string)
  {
    this._listFilter = value;
    //console.log(value);
    this.filterProducts = this.performFilter(value);
  }
  performFilter(filterBy:string) : IProduct[]
  {
    filterBy = filterBy.toLocaleLowerCase();
    return this.products.filter((product:IProduct)=>
    product.productName.includes(filterBy)
    );
  }
  toggleImage()
  {
    this.showImage = !this.showImage;
  }
  onRatingClicked(message:string):void
  {
    this.pageTitle = 'Product List ' + message;
  }

  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }
}
