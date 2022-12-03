using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroPessoaSF12.Interfaces;

namespace CadastroPessoaSF12.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica  //IPessoaFisica herda os atributs de Pessoa
    {//atributos

        public string? cpf { get; set; }

        public DateTime? dataNascimento { get; set; }


        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}