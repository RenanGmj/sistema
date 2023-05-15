using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema.classes
{
    public abstract class pessoa
    {
        public string? nome { get; set; }
        public endereco? endereço { get; set; }
        public bool endereçoComercial { get; set; }


        public abstract void pagarImposto(float rendimento);
       
    }
}