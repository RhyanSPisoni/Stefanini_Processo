import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Cidade } from '../models/cidades.model';
import { Pessoa } from '../models/pessoas.model';
// import { Product } from '../models/product.model';

@Injectable({
  providedIn: 'root',
})
export class DataService {
  public urlCidade = 'https://localhost:5001/City';
  public urlPessoa = 'https://localhost:5001/Person';
  constructor(private http: HttpClient) {}

  //CRUD - Cidade
  getCidades() {
    return this.http.get<Cidade[]>(`${this.urlCidade}`);
  }

  newCidade(data: any) {
    return this.http.post<Cidade>(`${this.urlCidade}/New`, data);
  }

  patchCidade(data: any) {
    return this.http.patch<Cidade>(`${this.urlCidade}/Update`, data);
  }

  deleteCidade(data: number) {
    return this.http.delete<Cidade>(`${this.urlCidade}/Delete/${data}`);
  }

  //CRUD - Pessoa
  getPessoa() {
    return this.http.get<Pessoa[]>(`${this.urlPessoa}`);
  }

  newPessoa(data: any) {
    return this.http.post<Pessoa>(`${this.urlPessoa}/New`, data);
  }

  patchPessoa(data: any) {
    return this.http.patch<Pessoa>(`${this.urlPessoa}/Update`, data);
  }

  deletePessoa(data: number) {
    return this.http.delete<Pessoa>(`${this.urlPessoa}/Delete/${data}`);
  }

  //   getCidadesId(private id: string){
  //     return this.http.get<any[]>('https://localhost:5001/Cities')
  //   }
}
