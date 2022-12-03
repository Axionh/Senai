using CadastroPessoaSF12.Classes;

PessoaFisica obj_PF = new PessoaFisica();

// DateTime agora;
obj_PF.nome = "Lozano";
obj_PF.cpf = "3434343434341";
obj_PF.rendimento = "1000";
// obj_PF.dataNascimento = ;

Console.WriteLine( $"NOME: {obj_PF.nome} recebe {obj_PF.rendimento} de salario");
// Console.WriteLine(obj_PF.cpf);
// Console.WriteLine(obj_PF.rendimento);
// Console.WriteLine(obj_PF.dataNascimento);
