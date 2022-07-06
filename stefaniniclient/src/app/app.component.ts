import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'stefaniniclient';

  isValid: boolean = true;
  ChangeData(valid: boolean) {
    this.isValid = valid;
  }
}