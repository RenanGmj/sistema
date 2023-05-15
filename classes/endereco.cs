using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema.classes
{
    public class endereco
    {
        public string? logradouro { get; set; }
        public int numero { get; set; }
        public string? complemento { get; set; }
        public bool endereçoComercial { get; set; }
    }
}