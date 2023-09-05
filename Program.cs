using Classes;
using sistema.Classes;

class Program{
    static void Main(string[] args)
    {
       // List<PessoaFisica> listaPf = new List<PessoaFisica>(); 
        static void BarraCarregamento(string textocarregamento){
        Console.WriteLine(textocarregamento);
        Thread.Sleep(500);

        for (var contador = 0; contador < 4; contador++){
        Console.Write(".");
        Thread.Sleep(500);
        }

        }
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.BackgroundColor = ConsoleColor.Magenta;

        BarraCarregamento("Iniciando");
        Console.WriteLine(@$"
***************************************************************
*                                                             *
*               Bem vindo ao sistema de cadastro              *
*               de pessoa fisica e juridica                   *
*                                                             *
***************************************************************
        ");
        Thread.Sleep(1000);
        Console.Clear();
        string opcao;
        
do {
        Console.WriteLine(@$"
***************************************************************
*              Selecione uma das opções abaixo                *
***************************************************************
*               1 - Pessoa Fisica                             *
*               2 - Pessoa Juridica                           *
*                                                             *
*               0 - Sair                                      *
***************************************************************
        ");

        opcao = Console.ReadLine();

        switch (opcao){
            case "1":
            PessoaFisica novaPessoa = new PessoaFisica();
            Endereco end = new Endereco();
            string opcaopf;

            do{
                Console.Clear();
Console.WriteLine(@$"
***************************************************************
*              Selecione uma das opções abaixo                *
***************************************************************
*               1 - Cadastrar Pessoa Fisica                   *
*               2 - Mostrar Pessoas Fisicas                   *
*                                                             *
*               0 - Voltar ao menu anterior                   *
***************************************************************
        ");
        opcaopf = Console.ReadLine();

        switch (opcaopf){
            case "1":

            Console.WriteLine("Digite o nome da pessoa fisica que deseja cadastrar");
            novaPessoa.nome = Console.ReadLine();

            Console.WriteLine("Digite o rendimento da pessoa fisica que deseja cadastrar");
            novaPessoa.rendimento = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o logradouro do endereço da pessoa fisica que deseja cadastrar");
            end.logradouro = Console.ReadLine();

            Console.WriteLine("Digite o cpf da pessoa fisica que deseja cadastrar");
            novaPessoa.cpf = Console.ReadLine();

            Console.WriteLine("Digite a data de nascimento da pessoa fisica que deseja cadastrar DD/MM/AAAA");
            novaPessoa.dataNascimento = DateTime.Parse(Console.ReadLine());

            bool idadeValidada = novaPessoa.ValidarDataNascimento(novaPessoa.dataNascimento);
       
            if (idadeValidada == true){
                Console.WriteLine("Cadastro APROVADO");
            }else{
                Console.WriteLine("Cadastro REPROVADO por motivos de idade");
            }

            //listaPf.Add(novaPessoa);
            //console readline (read = ler, line = linha)   console writeline (write = escrever, line = linha)


            using (StreamWriter banana = new StreamWriter($"{novaPessoa.nome}.txt"))
            {
                banana.WriteLine(@$"
***************************************************************
               Nome: {novaPessoa.nome}     
               Rendimento:{novaPessoa.rendimento}    
               Logradouro:{end.logradouro}    
               CPF:{novaPessoa.cpf}               
               Data de Nascimento: {novaPessoa.dataNascimento}                                                                
***************************************************************                
                ");
            }

            break;
            case "2":
            Console.Clear();
            //Pergunta o nome
            Console.WriteLine("Digite o nome da pessoa que deseja procurar o cadastro");
            string pessoa = Console.ReadLine();
            //lê o arquivo
            using(StreamReader sr = new StreamReader($"{pessoa}.txt")){
                string linha; //lê linha por linha
                while((linha = sr.ReadLine()) != null){
                    Console.WriteLine($"{linha}");
                }
            }
            //Fecha
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadLine();
    

            break;
            case "0":
            break;
            default:
            Console.Clear();
            Console.WriteLine("Opção invalida, por favor digite uma opção valida");
            Thread.Sleep(2000);
            break;


        }
            }while (opcaopf != "0");

            break;
            case "2":
        Endereco endpj = new Endereco();
        endpj.logradouro = "Rua X";
        endpj.numero = 100;
        endpj.complemento = "Proximo ao SENAI";
        endpj.enderecoComercial = false;

        PessoaJuridica pj = new PessoaJuridica();
        pj.endereco = endpj;
        pj.cnpj = "12345678000001";
        pj.razaoSocial = "Bar do cleito";
        pj.rendimento = 9000;

        Console.WriteLine($"{pj.PagarImposto(pj.rendimento)},00");

    //        if (pj.ValidarCNPJ(pj.cnpj)){
    //        Console.WriteLine("CNPJ VALIDO");
    //    }else{
    //        Console.WriteLine("CNPJ INVALIDO");
    //    }
            break;
            case "0":
            Console.WriteLine("Obrigado por utilizar o nosso sistema");
            Console.WriteLine("Digite qualquer tecla para sair");
            Console.ReadLine();
            BarraCarregamento("Finalizando");
            break;
            default:
            Console.WriteLine("Opção invalida, por favor digite uma das opções apresentadas");
            break;
        }
    }while (opcao != "0");

        Console.ResetColor();
    }
}