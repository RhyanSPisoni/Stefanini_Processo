using System;
using System.Collections.Generic;

namespace StefaniniServer.DTO
{
    public partial class CidadeDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Uf { get; set; } = null!;

        public virtual ICollection<PessoaDTO>? Pessoas { get; set; }
    }
}
