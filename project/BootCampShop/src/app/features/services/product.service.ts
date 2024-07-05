import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Product } from '../models/product.model';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private http: HttpClient) { }

  getProducts() : Observable<Product[]>
  {
    return this.http.get<Product[]>('https://localhost:7092/api/product')
  }

  addProduct(product: Product): Observable<Product> {
    return this.http.post<Product>('https://localhost:7092/api/product', product);
  }

  deleteProduct(product: Product): Observable<Product> {
    return this.http.delete<Product>(`https://localhost:7092/api/product/${product.id}`);
  }

  editProduct(id:string, product: Product): Observable<Product> {
    return this.http.put<Product>(`https://localhost:7092/api/product/${id}`, product);
  }

}
