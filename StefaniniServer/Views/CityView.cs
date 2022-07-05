using System;
using System.Collections.Generic;

namespace StefaniniServer.Views
{
    public partial class CityView
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Uf { get; set; } = null!;
    }
}
