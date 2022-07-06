import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-pessoa',
  templateUrl: './pessoa.component.html',
  styleUrls: ['./pessoa.component.css'],
})
export class PessoaComponent implements OnInit {
  public cidades$!: Observable<any[]>;

  constructor(private data: DataService) {}

  ngOnInit(): void {
    this.cidades$ = this.data.getCidades();
    console.log(this.data.getCidades());
  }
}
