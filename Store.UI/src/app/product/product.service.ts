import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Product } from './product';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  BASE_PATH = `http://localhost:8000/api/store`;

  constructor(private http: HttpClient) { }

  get():Observable<Product[]> {
    return this.http.get<Product[]>(`${this.BASE_PATH}/`);
  }
}
