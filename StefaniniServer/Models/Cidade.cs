using System;
using System.Collections.Generic;

namespace StefaniniServer.Models
{
    public partial class Cidade
    {
        public Cidade()
        {
            Pessoas = new HashSet<Pessoa>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Uf { get; set; } = null!;

        public virtual ICollection<Pessoa> Pessoas { get; set; }
    }
}
