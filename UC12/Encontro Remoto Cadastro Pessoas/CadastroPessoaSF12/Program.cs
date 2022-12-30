using CadastroPessoaSF12.Classes;
using System.Text.RegularExpressions; //importação RegEx

//************************Metodos GLOBAIS*****************************
PessoaFisica metodosPf = new PessoaFisica();
PessoaJuridica metodosPj = new PessoaJuridica();
List<PessoaFisica> ListaPf = new List<PessoaFisica>();//inicializa uma lista vazia
List<PessoaJuridica> ListaPj = new List<PessoaJuridica>();//inicializa uma lista vazia

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
        case "1"://----------Pessoa fisica------------//


            string opcaoPf;
            do
            {//submenu layout
                Console.WriteLine(@$"
=============================================
|      Escolha uma das opções abaixo        |
|-------------------------------------------|
|           1 - Cadastrar Pessoa Fisica     |
|           2 - Listar Pessoa Fisica        |
|                                           |
|           0 - Voltar                      |
=============================================
");
                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1":
                        Console.Clear();
                        // Console.WriteLine($"********** PESSOA FISICA **********");
                        Console.WriteLine();

                        //Preenchimento dos dados 
                        //Endereco da pessoa FISICA 1
                        Endereco enderecoPf = new Endereco();
                        Console.WriteLine($"Digite o endereço: ");
                        enderecoPf.Logradouro = Console.ReadLine();
                        Console.WriteLine($"Digite o número: ");
                        enderecoPf.Numero = int.Parse(Console.ReadLine());//converte o texto do writeline e transforma para  numero
                        Console.WriteLine($"Endereço comercial? s/n");
                        if (Console.ReadLine() == "s")
                        {
                            enderecoPf.Comercial = true;
                        }
                        else
                        {
                            enderecoPf.Comercial = false;
                        }
                        //Pessoa fisica 1 CADASTRO
                        PessoaFisica NovaPf = new PessoaFisica();
                        Console.WriteLine($"Digite o nome: ");
                        NovaPf.Nome = Console.ReadLine();
                        NovaPf.DataNascimento = new DateTime(2010, 07, 20);
                        Console.WriteLine($"Digite o CPF: ");
                        NovaPf.Cpf = Console.ReadLine();
                        Console.WriteLine($"Qual o seu rendimento bruto?");
                        NovaPf.Rendimento = float.Parse(Console.ReadLine());//transformar a string em float
                        NovaPf.Endereco = enderecoPf;

                        //guardar o nome na lista
                        ListaPf.Add(NovaPf); //guarda uma pessoa fisica na lista

                        Utils.ParadaNoConsole("Pessoa Fisica Cadastrada com sucesso!");

                        break;

                    case "2":
                        //EXIBIÇÃO PESSOA FISICA
                        Console.Clear();
                        Console.WriteLine($"------Listagem de Pessoas Fisicas-----");

                        foreach (var pessoa in ListaPf)
                        {//roda para cada pessoa da classe 
                            Console.WriteLine();
                            Console.WriteLine($"NOME: {pessoa.Nome}");
                            Console.WriteLine($"CPF: {pessoa.Cpf}");
                            Console.WriteLine($"Rendimento: {pessoa.Rendimento}");
                            // Console.WriteLine( $"Rendimento DESCONTO: R$ {pessoa.Rendimento - metodosPf.PagarImposto(pessoa.Rendimento)}");
                            Console.WriteLine($"Rendimento LIQUIDO: R$ {metodosPf.PagarImposto(pessoa.Rendimento)}");
                            Console.WriteLine($"Data de Nascimento: {pessoa.DataNascimento}");
                            //Console.WriteLine($"Maior de idade? {metodosPf.ValidarDataNascimento(pessoa.DataNascimento)}");
                            Console.WriteLine(metodosPf.ValidarDataNascimento(pessoa.DataNascimento)?"Maiorde idade: Sim":"Maior de idade? Não");
                            Console.WriteLine($"Rua: {pessoa.Endereco.Logradouro}");
                            Console.WriteLine($"Numero: {pessoa.Endereco.Numero}");
                            Console.WriteLine($"Endereco comercial? {pessoa.Endereco.Comercial}");
                            // //maneira d realizar usando o operador ternário, metodo mais avançado e poderia tirar o IF
                            //pleno
                            // string endComercial = (pessoa.Endereco.Comercial==true)? "Endereço Comercial? Sim" : "Endereço Comercial? Não"; 
                            //Console.WriteLine(endComercial);
                            
                            //senior
                            //Console.Writeline (pessoa.Endereco.Comercial)? "Endereço Comercial? Sim" : "Endereço Comercial? Não"; 

                            //maneira junior
                            if (pessoa.Endereco.Comercial == true)
                            {
                                Console.WriteLine($"Endereço comercial? Sim");
                            }
                            else
                            {
                                Console.WriteLine($"Endereço comercial? Não");

                            }
                        }
                        Utils.ParadaNoConsole("----------Fim da listagem----------");
                        break;

                    case "0":
                        Console.Clear();
                        Utils.ParadaNoConsole("Voltar ao menu anterior");
                        break;

                    default:
                        Console.Clear();
                        Utils.ParadaNoConsole("Opção invalida");
                        break;
                }


            } while (opcaoPf != "0");
            break;

        case "2": //---------Pessoa Juridica---------//









            //             Console.Clear();
            //             Console.WriteLine($"********** PESSOA JURIDICA **********");
            //             Console.WriteLine();

            //             //Endereco da pessoa juridica 1
            //             Endereco endPj = new Endereco();
            //             endPj.Logradouro = "Rua Niteroi";
            //             endPj.Numero = 180;
            //             endPj.Comercial = true;
            //             PessoaJuridica novaPj = new PessoaJuridica();

            //             //Pessoa juridica CADASTRO
            //             novaPj.Nome = "Paulo";
            //             novaPj.Endereco = endPj;
            //             novaPj.Rendimento = 10000;
            //             novaPj.Cnpj = "62.236.353/0001-42";//com mascara
            //             // novaPj.Cnpj = "62236353000142";//sem mascara
            //             novaPj.Fantasia = "SENAI";
            //             novaPj.Razaosocial = "Serviço Nacional de Aprendizagem Industrial";


            //             //EXIBICAO PESSOA JURIDICA
            //             Console.WriteLine($"Pessoa Jurídica 01");
            //             //adicionar o @ pode fazer varias linhas dentrode um CWL apenas  
            //             Console.WriteLine(@$"
            // Razão Social: {novaPj.Razaosocial}
            // Nome Fantasia: {novaPj.Fantasia}
            // Representante: {novaPj.Nome}
            // CNPJ: {novaPj.Cnpj}
            // CNPJ Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
            // Rendimento atual: {novaPj.Rendimento}
            // Rendimento LIQUIDO: {metodosPj.PagarImposto(novaPj.Rendimento)}
            // Endereço copleto: {novaPj.Endereco.Logradouro}, {novaPj.Endereco.Numero}, {novaPj.Endereco.Comercial}
            // ");
            //             Utils.ParadaNoConsole("Pessoa Juridica Cadastrada com sucesso!");
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