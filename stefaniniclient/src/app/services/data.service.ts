import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Cidade } from '../models/cidades.model';
import { Pessoa } from '../models/pessoas.model';

@Injectable({
  providedIn: 'root',
})
export class DataService {
  public urlCidade = 'https://apicontrollerperson.azurewebsites.net/City';
  public urlPessoa = 'https://apicontrollerperson.azurewebsites.net/Person';
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
    return this.http
      .patch<Pessoa>(`${this.urlPessoa}/Update`, data)
      .subscribe();
  }

  deletePessoa(data: number) {
    return this.http.delete<Pessoa>(`${this.urlPessoa}/Delete/${data}`);
  }
}
