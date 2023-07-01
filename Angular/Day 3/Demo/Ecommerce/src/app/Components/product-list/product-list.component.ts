import { Component } from '@angular/core';
import { IProduct } from 'src/app/Models/iproduct';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent {
  pageTitle:string = 'Product List';
  showImage:boolean = false;
  filterProducts:IProduct[] = [];
  imgWidth:number =60;
  imgMargin:number =2;
  products:IProduct[] =  [
    {
      productID:1,
      productName: 'mobile',
      productCode:'lenovo-y23',
      releaseDate:'2-2-2000',
      starRating: 2.2,
      price:200,
      description: 'decription for mobile',
      image:'https://picsum.photos/id/1/200/200'
    },
    {
      productID:2,
      productName: 'laptop',
      productCode:'HP-23p',
      releaseDate:'2-5-2002',
      starRating: 3,
      price:500,
      description: 'laptop HP for programming',
      image:'https://picsum.photos/id/1/200/200'
    },
    {
      productID:3,
      productName: 'tablet',
      productCode:'tab-78e',
      releaseDate:'2-5-2005',
      starRating: 3.5,
      price:700,
      description: 'tab new for drawing',
      image:'https://picsum.photos/id/1/200/200'
    },
    {
      productID:4,
      productName: 'samrt Watch',
      productCode:'sm-234',
      releaseDate:'2-5-2006',
      starRating: 3.6,
      price:500,
      description: 'smart watch from apple for time',
      image:'https://picsum.photos/id/1/200/200'
    },
    {
      productID:5,
      productName: 'inote',
      productCode:'cardoo-23r',
      releaseDate:'2-5-2010',
      starRating: 5,
      price:500,
      description: 'inote for instructor',
      image:'https://picsum.photos/id/1/200/200'
    }
  ];
  constructor()
  {
    this.listFilter = '';
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
}
