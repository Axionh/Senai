using CadastroPessoaSF12.Classes;
using System.Text.RegularExpressions; //importação RegEx

//************************Metodos*****************************
PessoaFisica metodosPf = new PessoaFisica();
PessoaJuridica metodosPj = new PessoaJuridica();

//************************Cabeçalho do sistema*****************************
Console.WriteLine(@$"
=============================================
|   Bem vindo ao sistema de cadastro de     |
|       Pessoas Fisicas e Juridicas         |
=============================================
");

//Loading
Utils.Loading("Iniciando", 3, 300);

//tempo para abrir o painel 
Thread.Sleep(1000); //tempo de espera para iniciar o proximo comando 

string? opcao;
do
{
    Console.WriteLine(@$"
=============================================
|      Escolha uma das opções abaixo        |
|-------------------------------------------|
|           1 - Pessoa Fisica               |
|           2 - Pessoa Juridica             |
|                                           |
|           0 - Sair                        |
=============================================
");

    opcao = Console.ReadLine();//espera o usuário digitar a opção

    switch (opcao)
    {
        case "1":
            Console.Clear();
            //Endereco da pessoa FISICA 1
            Endereco endPf1 = new Endereco();
            endPf1.Logradouro = "Rua de casa";
            endPf1.Numero = 123;
            endPf1.Comercial = false;

            //Pessoa fisica 1 CADASTRO
            PessoaFisica Pf1 = new PessoaFisica();
            Console.WriteLine($"********** PESSOA FISICA **********");
            Console.WriteLine();
            Pf1.Nome = "Alexandre Hoss";
            Pf1.DataNascimento = new DateTime(2010, 07, 20);
            Pf1.Cpf = "12345678910";
            Pf1.Rendimento = 1500.00f;//colocar o f depois do numeror para aceitar as casa decimais quando for float. Assim diferencia do double
            Pf1.Endereco = endPf1;

            //EXIBIÇÃO PESSOA FISICA
            Console.WriteLine($"NOME: {Pf1.Nome}");
            Console.WriteLine($"CPF: {Pf1.Cpf}");
            Console.WriteLine($"Rendimento: {Pf1.Rendimento}");
            // Console.WriteLine( $"Rendimento DESCONTO: R$ {Pf1.Rendimento - metodosPf.PagarImposto(Pf1.Rendimento)}");
            Console.WriteLine($"Rendimento LIQUIDO: R$ {metodosPf.PagarImposto(Pf1.Rendimento)}");
            Console.WriteLine($"Data de Nascimento: {Pf1.DataNascimento}");
            Console.WriteLine($"Maior de idade? {metodosPf.ValidarDataNascimento(Pf1.DataNascimento)}");
            Console.WriteLine($"Rua: {Pf1.Endereco.Logradouro}");
            Console.WriteLine($"Numero: {Pf1.Endereco.Numero}");
            Console.WriteLine($"Endereco comercial? {Pf1.Endereco.Comercial}");
            Utils.ParadaNoConsole("Pessoa Fisica Cadastrada com sucesso!");
            break;

        case "2":
            Console.Clear();
            //Endereco da pessoa juridica 1
            Endereco endPj = new Endereco();
            endPj.Logradouro = "Rua Niteroi";
            endPj.Numero = 180;
            endPj.Comercial = true;
            PessoaJuridica novaPj = new PessoaJuridica();

            //Pessoa juridica CADASTRO
            Console.WriteLine($"********** PESSOA JURIDICA **********");
            Console.WriteLine();
            novaPj.Nome = "Paulo";
            novaPj.Endereco = endPj;
            novaPj.Rendimento = 10000;
            novaPj.Cnpj = "62.236.353/0001-42";//com mascara
            // novaPj.Cnpj = "62236353000142";//sem mascara
            novaPj.Fantasia = "SENAI";
            novaPj.Razaosocial = "Serviço Nacional de Aprendizagem Industrial";


            //EXIBICAO PESSOA JURIDICA
            Console.WriteLine($"Pessoa Jurídica 01");
            //adicionar o @ pode fazer varias linhas dentrode um CWL apenas  
            Console.WriteLine(@$"
Razão Social: {novaPj.Razaosocial}
Nome Fantasia: {novaPj.Fantasia}
Representante: {novaPj.Nome}
CNPJ: {novaPj.Cnpj}
CNPJ Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
Rendimento atual: {novaPj.Rendimento}
Rendimento LIQUIDO: {metodosPj.PagarImposto(novaPj.Rendimento)}
Endereço copleto: {novaPj.Endereco.Logradouro}, {novaPj.Endereco.Numero}, {novaPj.Endereco.Comercial}
");
            Utils.ParadaNoConsole("Pessoa Juridica Cadastrada com sucesso!");
            break;

        case "0":
            Console.WriteLine($"Obrigado por usar o nosso sistema");
            Utils.ParadaNoConsole("Encerrando o sistema");
            break;

        default:
            Console.Clear();
            Utils.ParadaNoConsole("Opção Inválida", ConsoleColor.Yellow);
            break;
    }



    //faz algo, depois pergunta se é para continuar ou sair

} while (opcao != "0"); //enquanto a opção for diferente de 0 fica no loop


//Loading de finalizar
Utils.Loading("Finalizando", 3, 300);
Console.WriteLine();




// //************************Pessoa Fisica*****************************
// //Endereco da pessoa fisica 1
// Console.WriteLine($"********** PESSOA FISICA **********");
// Console.WriteLine();


// Console.WriteLine();



// //************************Pessoa Juridica*****************************









//***************************ESTUDOS DE CASO****************************

// DateTime data = new DateTime(1982,07,20);

// CNPJ Válido: {novaPj.ValidarCnpj(novaPj.Cnpj)}
// //****************Para fazer que o console pergunte valores e imprima os mesmos depois****************
// // Console.WriteLine($"Digite o nome fantasia:");
// // novaPj.Fantasia = Console.ReadLine(); //serve para poder escrever o nome dentro do console e guardar na variável
// // Console.WriteLine($"Qual é o rendimento?");
// // novaPj.Rendimento = float.Parse(Console.ReadLine ());//aqui é para pedir qual o rendimento e passar de string para float
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

//Substring - cada caractere tem um numero partindo do 0 e seguindo

// string nome = "Eduardo Costa";

// Console.WriteLine(nome.Substring(8));   //apartir da posição X da substring é escrito no console
// Console.WriteLine(nome.Substring(2,4));   //apartir da posição X da substring é escrito no console e será escrito X numeros de caracteres que quero

// Console.WriteLine(nome.Length); //conta a quantidade de caracteres que existe no nome
// Console.WriteLine(ThePeople.ValidarDataNascimento(data));