import { Component } from '@angular/core';
import { MatIconModule } from '@angular/material/icon';
import { NgIf } from '@angular/common';

@Component({
  selector: 'app-navbar',
  imports: [MatIconModule, NgIf],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent {
  IsCartActive: boolean = false;

  toggleCart() {
    this.IsCartActive = !this.IsCartActive;
  }

  
}
