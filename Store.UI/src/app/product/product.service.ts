import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Product } from './product';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class ProductService {
  private BASE_PATH = `http://localhost:8000/api/store`;
  p? : Product;
  constructor(private http: HttpClient) { }

  get():Observable<Product[]> {
    return this.http.get<Product[]>(`${this.BASE_PATH}/`);
  }

  create(product: Product): void {
    const httpOptions = {
      headers: new HttpHeaders({'Content-Type': 'application/json'})
    };

    this.http.post<any>(`${this.BASE_PATH}/`, JSON.stringify(product), httpOptions).subscribe({
      error: error => {
        console.error(error.message);
      }
    });
  }
}