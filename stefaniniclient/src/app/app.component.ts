import { Component, Input } from '@angular/core';
import { Observable } from 'rxjs';
import { Cidade } from './models/cidades.model';
import { DataService } from './services/data.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'stefaniniclient';

  constructor(private data: DataService) {}

  @Input() isValid: number = 1;

  ChangeData(valid: number) {
    this.isValid = valid;
  }

  public cidades$!: Observable<Cidade[]>;

  ngOnInit(): void {
    this.cidades$ = this.data.getCidades();
  }
}
