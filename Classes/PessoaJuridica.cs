using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Classes;

namespace sistema.Classes
{
    public class PessoaJuridica : Pessoa
    {
        public string? Cnpj { get; set; }

        public string? RazaoSocial { get; set; }

        public override double PagarImposto(float rendimento)
        {
            if(rendimento <= 5000){

                return rendimento * .03;

            }else if(rendimento >5000 && rendimento <= 10000){

                return rendimento * .08;
            }else{
                return rendimento * .001;
            }
        
        }

        public bool ValidarCnpj(string Cnpj){
            if((Cnpj.Length >= 14) && (Cnpj.Substring(Cnpj.Length-4))== "0001"){
                return true;

            }else{
                return false;
            }
        }
    }
}