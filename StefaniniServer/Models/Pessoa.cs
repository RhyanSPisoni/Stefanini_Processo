using System;
using System.Collections.Generic;

namespace StefaniniServer.Models
{
    public partial class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Cpf { get; set; } = null!;
        public int IdCidade { get; set; }
        public int Idade { get; set; }

        public virtual Cidade IdCidadeNavigation { get; set; } = null!;
    }
}
