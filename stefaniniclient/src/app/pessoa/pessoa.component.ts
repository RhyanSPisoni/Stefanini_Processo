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

  public nomepessoa!: string;
  public cpfpessoa!: string;
  public idadepessoa!: number;
  public cidadepessoa!: number;

  constructor(private data: DataService) {}

  submitPerson() {
    let bodyPessoa = {
      nome: this.nomepessoa,
      cpf: this.cpfpessoa,
      idCidade: this.cidadepessoa,
      idade: this.idadepessoa,
    };
    console.table(bodyPessoa);
    this.data.newPessoa(bodyPessoa).subscribe();
  }

  ngOnInit(): void {
    this.cidades$ = this.data.getCidades();
    console.log(this.data.getCidades());
  }
}
