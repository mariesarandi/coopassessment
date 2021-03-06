import { Component, OnInit } from '@angular/core';
import { ProductService } from '../product.service';
import { Product } from './pages/products';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  product = Product;

  constructor(private productService: ProductService) {
  }

  ngOnInit(): void {
  }

}
