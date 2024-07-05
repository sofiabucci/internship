import { Component, OnInit } from '@angular/core';
import { ProductService } from './../../services/product.service';
import {MatDialogRef} from '@angular/material/dialog'
import { Product } from '../../models/product.model';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';

@Component({
  selector: 'app-add-product',
  standalone: true,
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css'],
  imports: [ReactiveFormsModule, FormsModule]
})
export class AddProductComponent implements OnInit {

  product: Product ={
    id:'',
    name:'',
    category:'',
    price:0,
  }

  constructor(private productService: ProductService, public dialogRef : MatDialogRef<AddProductComponent>) { }

  ngOnInit(): void {}

  closeModal(){
    this.productService.addProduct(this.product).subscribe(() =>
    {
      console.log('Product added successfully');
      this.dialogRef.close();
    },
    error => {
      console.error('Error adding product:', error);
    });
  }
}

