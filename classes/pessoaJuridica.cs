using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema.classes
{
    public class pessoaJuridica : pessoa
    {
        public int cnpj { get; set; }
        public string? razaoSocial { get; set; }

         public override void pagarImposto(float rendimento)
        {
            
        }
    }
}