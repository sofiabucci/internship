import { Product } from './../../models/product.model';
import { Component, Inject, OnInit } from '@angular/core';
import { ProductService } from './../../services/product.service';
import {MAT_DIALOG_DATA, MatDialogRef} from '@angular/material/dialog'
import { ReactiveFormsModule, FormsModule } from '@angular/forms';

@Component({
  selector: 'app-edit-product',
  standalone: true,
  templateUrl: './edit-product.component.html',
  styleUrls: ['./edit-product.component.css'],
  imports: [ReactiveFormsModule, FormsModule]
})
export class EditProductComponent implements OnInit {

  constructor(private productService: ProductService, public dialogRef : MatDialogRef<EditProductComponent>, @Inject(MAT_DIALOG_DATA) public data: Product) { }

  ngOnInit(): void {}

  product: Product ={
    id:this.data.id,
    name:this.data.name,
    category:this.data.category,
    price:this.data.price,
  }

  closeModal() {

    this.productService.editProduct(this.data.id, this.product).subscribe
    (() =>
      {
        console.log('Product edited successfully');
        this.dialogRef.close();
      },
      error => {
        console.error('Error editing product:', error);
      }
    );
  }
}
