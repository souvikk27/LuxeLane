import { Component } from '@angular/core';
import { AdminnavComponent } from './adminnav/adminnav.component';

@Component({
  selector: 'app-admin',
  standalone: true,
  templateUrl: './admin.component.html',
  styleUrl: './admin.component.css',
  imports: [AdminnavComponent]
})
export class AdminComponent {

}
