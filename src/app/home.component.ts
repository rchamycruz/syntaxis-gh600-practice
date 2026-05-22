import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  protected readonly title = 'Base Project Angular';
  protected readonly description = 'Aplicación de bienvenida creada con Angular 20 y routing.';
}
