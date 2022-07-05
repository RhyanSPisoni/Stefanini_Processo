using System;
using System.Collections.Generic;

#nullable disable

namespace StefaniniServer.Models
{
    public partial class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int IdCidade { get; set; }
        public int Idade { get; set; }

        public virtual Cidade IdCidadeNavigation { get; set; }
    }
}
