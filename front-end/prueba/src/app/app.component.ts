import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import {PruebaLoginComponent} from './prueba-login/prueba-login.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, PruebaLoginComponent],
  templateUrl: './app.component.html', 
  styleUrl: './app.component.css'

})
export class AppComponent {
  cuenta = 3;
}
