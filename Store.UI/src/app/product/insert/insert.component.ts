import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Product } from '../product';
import { AbstractControl, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-insert',
  templateUrl: './insert.component.html',
  styleUrls: ['./insert.component.scss']
})
export class InsertComponent implements OnInit {
  form: FormGroup = new FormGroup({
    fullname: new FormControl(''),
    username: new FormControl(''),
    email: new FormControl(''),
    password: new FormControl(''),
    confirmPassword: new FormControl(''),
    acceptTerms: new FormControl(false),
  });
  submitted = false;
  product: Product = new Product;

  constructor(
    private router: Router, 
    private formBuilder: FormBuilder, 
    private productService: ProductService) { }

  back() {
    this.router.navigate(['products']);
  }

  get f(): { [key: string]: AbstractControl } {
    return this.form.controls;
  }

  onSubmit(): void {
    this.submitted = true;

    if (this.form.invalid) {
      return;
    }

    let newProduct: Product = {
      id: '',
      name: this.form.value.name,
      price: this.form.value.price, 
      isDeleted: false, 
      pictureUrl: this.form.value.pictureUrl 
    };

    this.productService.create(newProduct);

    this.back();
  }

  ngOnInit(): void {
    this.form = this.formBuilder.group(
    {
      name: [
        '',
        [
          Validators.required,
          Validators.minLength(3),
          Validators.maxLength(50)
        ]
      ],
      price: [
        '',
        Validators.required
      ],
      pictureUrl: [
        '',
        Validators.required
      ],
    });
  }
}
