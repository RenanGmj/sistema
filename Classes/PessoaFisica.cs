using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Classes;

namespace sistema.Classes
{
    public class PessoaFisica : Pessoa
    {
        public string? Cpf { get; set; }

        public DateTime? DataDeNascimento { get; set; }

        public override double PagarImposto(float rendimento)
        {
            if(rendimento <= 5000){
                return 0;
            }else if(rendimento >= 5001 && rendimento <= 10000 ){

                return rendimento * 03;

            }else{

                return rendimento * 05;
                
            }
        
        }

        public bool ValidarDataDeNasscimento(DateTime DataDeNascimento){

            DateTime DataAtual = DateTime.Today;

            Double anos = (DataAtual-DataDeNascimento).TotalDays/365;

            if ( anos >=18){
                return true;
            }else{
                return false;
            }

        }
    }
}