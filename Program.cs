using Classes;
using sistema.Classes;

class Program{
    static void Main(string[] args)
    {
       // Endereco end = new Endereco();
       // end.Logradouro = "rua x";
       // end.Numero = 19;
       // end.Complemento = " na esquina";
       // end.EnderecoComercial = false;
//
//
       // PessoaFisica novaPessoa = new PessoaFisica();
       // novaPessoa.Nome = "renan";
       // novaPessoa.Cpf = "132545577";
       // novaPessoa.DataDeNascimento = new DateTime(2001, 08, 27);
//
       // Console.WriteLine( novaPessoa.Nome);

        Endereco endPJ = new Endereco();
        endPJ.Logradouro = "rua x";
        endPJ.Numero = 19;
        endPJ.Complemento = " na esquina";
        endPJ.EnderecoComercial = false;

        PessoaJuridica PJ = new PessoaJuridica();
        PJ.Nome = "josé";
        PJ.Cnpj = "12547896310001";
        PJ.RazaoSocial = "bar do ze";
        PJ.Rendimento =5002;

        Console.WriteLine($"{PJ.PagarImposto(PJ.Rendimento)},00");


        if(PJ.ValidarCnpj(PJ.Cnpj)){
            Console.WriteLine("CNPJ VALIDO ");
        }else{
            Console.WriteLine("CNPJ INVALIDO");
        }

        
        




    }
}
