import { Component, OnDestroy, OnInit } from '@angular/core';
import { ProductService } from '../product.service';
import { Product } from '../product';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {
  products: Product[] = [];

  constructor(private productService: ProductService) { }

  ngOnInit(): void {
    this.productService.get().subscribe((data: Product[]) => {
      this.products = data;
      console.log('data: ' + data);
      console.log('this.products: ' + this.products);
    });

    const x = this.products.length;
    console.log('this.products2: ' + this.products);
  }

  filterProducts() : void {
    
  }

  showCreatePage() {

  }
}
