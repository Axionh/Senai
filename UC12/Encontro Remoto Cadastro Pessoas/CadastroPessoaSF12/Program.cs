using CadastroPessoaSF12.Classes;
using System.Text.RegularExpressions; //importação RegEx



// //************cadastro da pessoa juridica************
Endereco endPj = new Endereco();
endPj.Logradouro = "Rua Niteroi";
endPj.Numero = 180;
endPj.Comercial = true;

PessoaJuridica novaPj = new PessoaJuridica();

// //****************Para fazer que o console pergunte valores e imprima os mesmos depois****************
// // Console.WriteLine($"Digite o nome fantasia:");
// // novaPj.Fantasia = Console.ReadLine(); //serve para poder escrever o nome dentro do console e guardar na variável
// // Console.WriteLine($"Qual é o rendimento?");
// // novaPj.Rendimento = float.Parse(Console.ReadLine ());//aqui é para pedir qual o rendimento e passar de string para float


//****************Dados pessoa juridica*****************
novaPj.Nome = "Paulo";
novaPj.Endereco = endPj;
novaPj.Rendimento = 100000;
novaPj.Cnpj = "62.236.353/0001-42";//com mascara
// novaPj.Cnpj = "62236353000142";//sem mascara
novaPj.Fantasia = "SENAI";
novaPj.Razaosocial = "Serviço Nacional de Aprendizagem Industrial";

//Exibição dos dados
Console.WriteLine($"Pessoa Jurídica 01");
//adicionar o @ pode fazer varias linhas dentrode um CWL apenas  
Console.WriteLine(@$"
Razão Social: {novaPj.Razaosocial}
Nome Fantasia: {novaPj.Fantasia}
Representante: {novaPj.Nome}
CNPJ: {novaPj.Cnpj}
CNPJ Válido: {novaPj.ValidarCnpj(novaPj.Cnpj)}
Rendimento atual: {novaPj.Rendimento}
Endereço copleto: {novaPj.Endereco.Logradouro}, {novaPj.Endereco.Numero}, {novaPj.Endereco.Comercial}
");  












//***************************ESTUDOS DE CASO****************************
// string data = "40/12/2022";

// bool dataValida = Regex.IsMatch(data, @"^\d{2}/\d{2}/\d{4}$" ); //(data, "") o data é a variavel e dentro do "" está o padrão de como é para ser. O @ é usado para poder usar coaracteres especiais. d{2} significa que é digito com 2 itens e assim por diante. RegEx serve para verificar uma expressão regular. ^é o inicio e $ é o final

// Console.WriteLine (data);
// Console.WriteLine(dataValida);
//teste para validar dia e mes com if
// if (dataValida)
// {
//     String [] partes =data.Split("/");
//     if (int.Parse(partes[0])>=1 && int.Parse(partes[0])<=31)
//     {
             
//     }
//     else{
//         Console.WriteLine("Dia Inválido");
//     }
//     if (int.Parse(partes[1])>=1 && int.Parse(partes[1])<=12)
//     {
             
//     }
//     else{
//         Console.WriteLine("Mês Inválido");
//     }
    
// }
//************************cadastro da pessoa fisica*****************************
//endereco da pessoa fisica 1
// Endereco endPf1 = new Endereco();
// endPf1.Logradouro = "Rua de casa";
// endPf1.Numero = 123;
// endPf1.Comercial = false;

// //Pessoa fisica 1
// PessoaFisica Pf1 = new PessoaFisica();
// Pf1.Nome = "Alexandre Hoss";
// Pf1.DataNascimento = new DateTime(2010,07,20);
// Pf1.Cpf = "12345678910";
// Pf1.Rendimento = 1000;
// Pf1.Endereco = endPf1;

// //Pessoa Fisica 2
// PessoaFisica ThePeople = new PessoaFisica("12345678910");
// ThePeople.Nome = "Joao";
// ThePeople.DataNascimento = new DateTime(2000,07,20);
// ThePeople.Cpf = "12345678910";
// ThePeople.Rendimento = 31000;
// ThePeople.Endereco = endPf1;

// Console.WriteLine( ThePeople.ValidarDataNascimento ("20/07/2010") );//retorn da funcao 

// //Exibir os dados
// Console.WriteLine($"PESSOA FISICA 1");

// Console.WriteLine( $"NOME: {Pf1.Nome}");
// Console.WriteLine( $"CPF: {Pf1.Cpf}");
// Console.WriteLine( $"Rendimento: {Pf1.Rendimento}");
// Console.WriteLine( $"Data de Nascimento: {Pf1.DataNascimento}");
// Console.WriteLine( $"Maior de idade? {Pf1.ValidarDataNascimento( Pf1.DataNascimento)}");
// Console.WriteLine( $"Rua: {Pf1.Endereco.Logradouro}");
// Console.WriteLine( $"Numero: {Pf1.Endereco.Numero}");
// Console.WriteLine( $"Endereco comercial? {Pf1.Endereco.Comercial}");

// Console.WriteLine();

// Console.WriteLine($"PESSOA FISICA 2");
// Console.WriteLine( $"NOME: {ThePeople.Nome}");
// Console.WriteLine( $"CPF: {ThePeople.Cpf}");
// Console.WriteLine( $"Rendimento: {ThePeople.Rendimento}");
// Console.WriteLine( $"Data de Nascimento: {ThePeople.DataNascimento}");
// Console.WriteLine( $"Maior de idade? {ThePeople.ValidarDataNascimento(ThePeople.DataNascimento)}");
// Console.WriteLine( $"Rua: {ThePeople.Endereco.Logradouro}");
// Console.WriteLine( $"Numero: {ThePeople.Endereco.Numero}");
// Console.WriteLine( $"Endereco comercial? {ThePeople.Endereco.Comercial}");

// DateTime data = new DateTime(1982,07,20);

//Substring - cada caractere tem um numero partindo do 0 e seguindo

// string nome = "Eduardo Costa";

// Console.WriteLine(nome.Substring(8));   //apartir da posição X da substring é escrito no console
// Console.WriteLine(nome.Substring(2,4));   //apartir da posição X da substring é escrito no console e será escrito X numeros de caracteres que quero

// Console.WriteLine(nome.Length); //conta a quantidade de caracteres que existe no nome
// Console.WriteLine(ThePeople.ValidarDataNascimento(data));