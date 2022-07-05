using System;
using System.Collections.Generic;

namespace StefaniniServer.Views
{
    public partial class PersonView
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Cpf { get; set; } = null!;
        public string Cidade { get; set; } = null!;
        public int Idade { get; set; }

    }
}
