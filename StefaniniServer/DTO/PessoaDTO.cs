using System;
using System.Collections.Generic;

namespace StefaniniServer.DTO
{
    public partial class PessoaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Cpf { get; set; } = null!;
        public int IdCidade { get; set; }
        public int Idade { get; set; }

        public virtual CidadeDTO IdCidadeNavigation { get; set; } = null!;
    }
}
