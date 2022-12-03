using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroPessoaSF12.Interfaces;

namespace CadastroPessoaSF12.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {//atributos
        public string ?cnpj {get;set;}

        public string ?razaosocial {get;set;}


        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}