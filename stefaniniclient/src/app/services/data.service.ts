import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
// import { Product } from '../models/product.model';

@Injectable({
  providedIn: 'root',
})
export class DataService {
  public url = 'http://localhost:3000/v1';

  constructor(private http: HttpClient) {}

  getCidades() {
    return this.http.get<any[]>('https://localhost:5001/Cities');
  }

  //   getCidadesId(private id: string){
  //     return this.http.get<any[]>('https://localhost:5001/Cities')
  //   }
}
