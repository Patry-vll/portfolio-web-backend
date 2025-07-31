import { Component } from '@angular/core';
import {RetoLogoComponent} from '../reto-logo/reto-logo.component';

@Component({
  selector: 'app-prueba-login',
  standalone: true,
  imports: [RetoLogoComponent],
  templateUrl: './prueba-login.component.html',
  styleUrl: './prueba-login.component.css'
})
export class PruebaLoginComponent {
  nombre: string = "Daniel";
  edad: number = 35;

}
