import { Component } from '@angular/core';
import { NavComponent } from "./nav/nav.component";

@Component({
    selector: 'app-main',
    standalone: true,
    templateUrl: './main.component.html',
    styleUrl: './main.component.css',
    imports: [NavComponent]
})
export class MainComponent {

}
