import { ProductService } from './features/services/product.service';
import { Component } from '@angular/core';
import { Routes } from '@angular/router';
import { ProductListComponent } from './features/product/product-list/product-list.component';

export const routes: Routes = [
  {
    path: 'admin/products',
    component: ProductListComponent,
  }
];
