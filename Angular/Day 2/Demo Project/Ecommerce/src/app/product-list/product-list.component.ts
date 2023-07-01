import { Component } from '@angular/core';
import { IProduct } from './iproduct';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent {
  pageTitle:string = 'Product List';
  products:IProduct[] = [
    {
      productID:1,
      productName : 'product 1',
      productCode:"New Code",
      releaseDate:'1-2-2000',
      describtion:"Hello new describtion",
      price:12.3,
      starRating:2.2,
      imgUrl: 'https://fakeimg.pl/250x250/'
    },
    {
      productID:2,
      productName : 'product 2',
      productCode:"New Code 2",
      releaseDate:'1-4-2000',
      describtion:"Hello new describtion 2",
      price:12.5,
      starRating:3.2,
      imgUrl: 'https://fakeimg.pl/250x250/'
    }

  ]
}
