import { Injectable } from '@angular/core';
import { Observable, catchError, tap, throwError } from 'rxjs';
import { IProduct } from '../Models/iproduct';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class ProductService {
  private productUrl = 'api/products/products.json';
  constructor(private http:HttpClient)
  { }

  getProducts() : Observable<IProduct[]>
  {
    console.log(this.productUrl);
    return this.http.get<IProduct[]>(this.productUrl)
    .pipe(
      tap(data=> console.log('All', JSON.stringify(data)),
      catchError(this.handleError)
    )
    )
  }

  private handleError(err:HttpErrorResponse)
  {
    let errorMessage = '';
    if(err.error instanceof ErrorEvent)
    {
      // client side error handling
      errorMessage = err.error.message
    }
    else
    {
      errorMessage = `server return code ${err.status} , error message : ${err.message}`;
    }
    console.log(errorMessage);
    return throwError (()=> errorMessage);

  }
}
