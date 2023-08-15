using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema.Classes;

namespace Classes
{
    public abstract class Pessoa
    {
        public string? Nome { get; set; }

        public Endereco? Endereco { get; set; }

        public float Rendimento { get; set; }


        public abstract double PagarImposto(float rendimento);

    }
}