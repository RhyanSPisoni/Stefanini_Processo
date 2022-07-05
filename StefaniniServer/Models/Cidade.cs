using System;
using System.Collections.Generic;

#nullable disable

namespace StefaniniServer.Models
{
    public partial class Cidade
    {
        public Cidade()
        {
            Pessoas = new HashSet<Pessoa>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }

        public virtual ICollection<Pessoa> Pessoas { get; set; }
    }
}
