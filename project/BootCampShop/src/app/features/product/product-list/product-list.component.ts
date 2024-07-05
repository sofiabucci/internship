import { Product } from '../../models/product.model';
import { ProductService } from './../../services/product.service';
import { Component, ViewChild } from '@angular/core';
import { OnInit } from '@angular/core';
import {MatDialogRef, MatDialog, MatDialogConfig} from '@angular/material/dialog'
import { AddProductComponent } from '../add-product/add-product.component';
import { EditProductComponent } from '../edit-product/edit-product.component';


@Component({
  selector: 'app-root',
  standalone: true,
  imports: [],
  templateUrl: './product-list.component.html',
  styleUrl: './product-list.component.css'
})
export class ProductListComponent implements OnInit{

  products?: Product[];

  dialogAdd = new MatDialogConfig();
  modalAdd: MatDialogRef<AddProductComponent, any> | undefined;

  dialogEdit = new MatDialogConfig();
  modalEdit: MatDialogRef<EditProductComponent, any> | undefined;

  constructor(private productService: ProductService, public matDialog: MatDialog) {}

  ngOnInit(): void {
    this.productService.getProducts().subscribe({
      next: (response) => {
        this.products = response;
      }
    });
  }

  ngAfterViewInit(): void {
    document.onclick = (args: any): void => {
      if (args.target.tagName === 'BODY') {
        this.modalAdd?.close();
        this.modalEdit?.close();
      }
    };
    this.matDialog.afterAllClosed.subscribe(() => {
      this.ngOnInit();
    });
  }

  openAddModal(): void {
    this.dialogAdd.id = "projects-modal-component";
    this.modalAdd = this.matDialog.open(AddProductComponent, this.dialogAdd);
  }

  openEditModal(product: Product): void {
    this.dialogEdit.id = "projects-modal-component";
    this.modalEdit = this.matDialog.open(EditProductComponent, {
      data: product
    });
  }

  deleteProduct(product: Product): void {
    console.log('called')
    this.productService.deleteProduct(product).subscribe({
      next: () => {
        console.log('deleted')
        this.products = this.products?.filter(p => p.id !== product.id);
      }
    });
  }

}
