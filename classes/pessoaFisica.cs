using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema.classes
{
    public class pessoaFisica : pessoa
    {
        public int cpf { get; set; }
        public DateTime dataDeNascimento { get; set; }
         public override void pagarImposto(float rendimento)
        {
            
        }

        public bool validarDataDeNascimento(DateTime dataDeNascimento)
        {
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - dataDeNascimento).TotalDays/365;

            if (anos>=18){
                return true;
            }else{
                return false;
            }
        }

    }
}