import { Component, EventEmitter, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Cidade } from '../models/cidades.model';
import { Pessoa } from '../models/pessoas.model';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-tabela',
  templateUrl: './tabela.component.html',
  styleUrls: ['./tabela.component.css'],
  //  : '../app.component.ts'
})
export class TabelaComponent implements OnInit {
  constructor(private data: DataService) {}
  public rowidTabela!: number;
  public idifpatch: number = 0;

  public nomepatchpessoa!: string;
  public cpfpatchpessoa!: string;
  public cidadepatchpessoa!: string;
  public idadepatchpessoa!: string;

  public visible: boolean = false;

  public pessoas$!: Observable<Pessoa[]>;
  public cidades$!: Observable<Cidade[]>;

  ngOnInit(): void {
    this.pessoas$ = this.data.getPessoa();

    console.table(this.pessoas$);
    this.cidades$ = this.data.getCidades();
  }

  onGetPessoa() {
    this.pessoas$ = this.data.getPessoa();
  }

  onLoadCidades() {
    this.cidades$ = this.data.getCidades();
  }

  async onDeleteRow(data: any) {
    this.data.deletePessoa(data).subscribe();
    await this.onGetPessoa();
  }

  onUpdateRow(data: any) {
    let bodyPessoa = {
      id: data,
      nome: this.nomepatchpessoa,
      cpf: this.cpfpatchpessoa,
      idCidade: this.cidadepatchpessoa,
      idade: this.idadepatchpessoa,
    };

    this.data.patchPessoa(bodyPessoa);
  }

  onChooseUpdate(data: any) {
    this.idifpatch = data;
  }

  AlterSelect(hash: boolean) {
    this.visible = hash;
  }

  backSession() {
    location.reload();
  }
}
