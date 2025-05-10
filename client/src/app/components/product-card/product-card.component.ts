import { Component } from '@angular/core';
import { NgOptimizedImage } from '@angular/common';
import { Product } from '../../models/product.model';
import { CurrencyPipe } from '@angular/common';
import { MatIconModule } from '@angular/material/icon';

@Component({
  selector: 'app-product-card',
  imports: [NgOptimizedImage, CurrencyPipe, MatIconModule],
  templateUrl: './product-card.component.html',
  styleUrl: './product-card.component.css'
})
export class ProductCardComponent {
  product: Product = {
    id: 0,
    model: 'Nautilus',
    brand: 'Patek Philippe',
    price: 22500,
    imagesUrls: ['https://xelorwatches.com/wp-content/uploads/2023/09/PATEK-PHILIPPE-NAUTILUS-%E2%80%93-57111A-001-%E2%80%93-STEEL-40mm.png',
      'https://th.bing.com/th/id/OIP.s-fAAGrOYb0g7m2pjyygawHaHa?cb=iwc2&rs=1&pid=ImgDetMain'
    ]
  };
  productImgIndex: number = 0;

  nextImage() {
    this.productImgIndex = (this.productImgIndex + 1) % this.product.imagesUrls.length;
  }

  previousImage() {
    this.productImgIndex = (this.productImgIndex + 1) % this.product.imagesUrls.length;
  }
}
