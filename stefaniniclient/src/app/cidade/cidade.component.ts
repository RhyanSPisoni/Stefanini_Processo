import { Component, Input, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Cidade } from '../models/cidades.model';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-cidade',
  templateUrl: './cidade.component.html',
  styleUrls: ['./cidade.component.css'],
})
export class CidadeComponent implements OnInit {
  @Input() cidade!: Cidade;
  
  public nomecidade!: string;
  public ufcidade!: string;

  constructor(private data: DataService) {}

  ngOnInit(): void {}

  submitCity() {
    console.log(this.nomecidade);
    console.log(this.ufcidade);

    let bodyCidade = {
      nome: this.nomecidade,
      uf: this.ufcidade,
    };
    // console.table(bodyCidade);
    this.data.newCidade(bodyCidade).subscribe();
  }
}
