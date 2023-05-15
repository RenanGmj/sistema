using sistema.classes;

class program{
    static void Main(string[] args)
    {
        pessoaFisica novaPessoa = new pessoaFisica();
        novaPessoa.nome = "caique";
        novaPessoa.cpf = 500123654;
        
        
        
        Console.WriteLine("seu nome é, " + novaPessoa.nome + "seu cpf é, " + novaPessoa.cpf);
    }
}

