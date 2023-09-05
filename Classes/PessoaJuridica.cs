using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Classes;

namespace sistema.Classes
{
    public class PessoaJuridica : Pessoa
    {
        public string? cnpj { get; set; }
        public string? razaoSocial { get; set; }

// Para rendimentos até R$5.000,00- desconto de 6%
// Para rendimentos entre R$5.001,00 e R$10.000,00 - desconto de 8%
// Para rendimentos acima de R$10.000,01 - desconto de 10%
    public override double PagarImposto(float rendimento)
{
    if(rendimento <=5000){

        return (rendimento/100) * 6;

    } else if(rendimento > 5000 && rendimento <= 10000){

        return (rendimento/100) * 8;

    } else{

        return (rendimento/100) * 1;

    }


}

        // somente permitir o cadastro com 14 números
        // sendo os 4 antepenúltimos 0001. 
        // configurar uma mensagem de erro.



    

        public bool ValidarCnpj(string Cnpj){
            if((Cnpj.Length >= 14) && (Cnpj.Substring(Cnpj.Length-4))== "0001"){
                return true;

            }else{
                return false;
            }
        }
    }
}