using CadastroPessoaSF12.Classes;


//cadastro da pessoa fisica
//endereco da pessoa fisica 1
Endereco endPf1 = new Endereco();
endPf1.Logradouro = "Rua de casa";
endPf1.Numero = 123;
endPf1.Comercial = false;

//Pessoa fisica 1
PessoaFisica Pf1 = new PessoaFisica();
Pf1.Nome = "Alexandre Hoss";
Pf1.DataNascimento = new DateTime(2005,07,20);
Pf1.Cpf = "12345678910";
Pf1.Rendimento = 1000;
Pf1.Endereco = endPf1;

//Pessoa Fisica 2
PessoaFisica ThePeople = new PessoaFisica("12345678910");
ThePeople.Nome = "Joao";
// ThePeople.Cpf = "12345678910";
ThePeople.Rendimento = 31000;
ThePeople.Endereco = endPf1;



Console.WriteLine( ThePeople.ValidarDataNascimento ("20/07/2010") );//retorn da funcao 



//Exibir os dados 
Console.WriteLine( $"NOME: {Pf1.Nome}");
Console.WriteLine( $"CPF: {Pf1.Cpf}");
Console.WriteLine( $"Rendimento: {Pf1.Rendimento}");
Console.WriteLine( $"Data de Nascimento: {Pf1.DataNascimento}");
Console.WriteLine( $"Maior de idade? {Pf1.ValidarDataNascimento( Pf1.DataNascimento)}");
Console.WriteLine( $"Rua: {Pf1.Endereco.Logradouro}");
Console.WriteLine( $"Numero: {Pf1.Endereco.Numero}");
Console.WriteLine( $"Endereco comercial? {Pf1.Endereco.Comercial}");

Console.WriteLine();

Console.WriteLine($"PESSOA FISICA 2");
Console.WriteLine( $"NOME: {ThePeople.Nome}");
Console.WriteLine( $"CPF: {ThePeople.Cpf}");
Console.WriteLine( $"Rendimento: {ThePeople.Rendimento}");
Console.WriteLine( $"Data de Nascimento: {ThePeople.DataNascimento}");
Console.WriteLine( $"Maior de idade? {ThePeople.ValidarDataNascimento(ThePeople.DataNascimento)}");
Console.WriteLine( $"Rua: {ThePeople.Endereco.Logradouro}");
Console.WriteLine( $"Numero: {ThePeople.Endereco.Numero}");
Console.WriteLine( $"Endereco comercial? {ThePeople.Endereco.Comercial}");


DateTime data = new DateTime(1982,07,20);

Console.WriteLine(ThePeople.ValidarDataNascimento(data));
