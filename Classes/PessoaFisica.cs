using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Classes;

namespace sistema.Classes
{
   public class PessoaFisica : Pessoa
    {
        public string? cpf { get; set; }
        public DateTime dataNascimento { get; set; }

// Pessoa física
// Para rendimentos até R$1.500,00 - isento (desconto 0)
// Para rendimentos entre R$1.501,00 e R$5.000,00 - desconto de 3%
// Para rendimentos acima de R$5.000,01 - desconto de 5%
        public override double PagarImposto(float rendimento)
        {
            if(rendimento <= 1500){
                return 0;
            } else if(rendimento > 1500 && rendimento <= 5000){
                return rendimento * .03;
                //return (rendimento/100) * 3
                //return rendimento * 0,03
            }else{
                return (rendimento/100) * 5;
            }
        }

        public bool ValidarDataNascimento(DateTime dataNascimento){
            
            DateTime dataAtual = DateTime.Today;

           double anos = (dataAtual - dataNascimento).TotalDays / 365;

           if (anos >= 18){
            return true;
           }else{
            return false;
           }
        }
    }
}