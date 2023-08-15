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
        PJ.Nome = "ze da manga";
        PJ.Cnpj = "12547896310001";
        PJ.RazaoSocial = "bar do ze ds manga";
        PJ.Rendimento =5002;

        
        if(PJ.ValidarCnpj(PJ.Cnpj)){
            Console.WriteLine("CNPJ VALIDO zé da manga");
        }else{
            Console.WriteLine("CNPJ INVALIDO");
        }

        Console.WriteLine(PJ.Cnpj);
        




    }
}
