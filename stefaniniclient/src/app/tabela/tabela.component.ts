import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Pessoa } from '../models/pessoas.model';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-tabela',
  templateUrl: './tabela.component.html',
  styleUrls: ['./tabela.component.css'],
})
export class TabelaComponent implements OnInit {
  constructor(private data: DataService) {}
  public rowidTabela!: number;
  public idifpatch : number = 0;

  public pessoas$!: Observable<Pessoa[]>;

  ngOnInit(): void {
    this.pessoas$ = this.data.getPessoa();
  }

  onGetPessoa() {
    this.pessoas$ = this.data.getPessoa();
  }

  async onDeleteRow(data: any) {
    this.data.deletePessoa(data).subscribe();
    await this.onGetPessoa();
  }

  onUpdateRow(data: any) {
    this.data.patchPessoa(data).subscribe;
  }

  onChooseUpdate(data: any) {
    this.idifpatch = data;
  }
}
