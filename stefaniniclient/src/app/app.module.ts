import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PessoaComponent } from './pessoa/pessoa.component';
import { CidadeComponent } from './cidade/cidade.component';
import { FormsModule } from '@angular/forms';
import { TabelaComponent } from './tabela/tabela.component';

@NgModule({
  declarations: [
    AppComponent,
    PessoaComponent,
    CidadeComponent,
    TabelaComponent,
  ],
  imports: [BrowserModule, AppRoutingModule, HttpClientModule, FormsModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
