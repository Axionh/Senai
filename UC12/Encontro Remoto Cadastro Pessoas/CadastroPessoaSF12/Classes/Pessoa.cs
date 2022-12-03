using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroPessoaSF12.Interfaces;

namespace CadastroPessoaSF12.Classes
{
    public abstract class Pessoa : IPessoa

    {        //atributos
        public string ?nome {get;set;} //o ponto de interrogacao permite o valor nulo

        public string ?endereco {get;set;}

        public string ?rendimento {get;set;}

        public abstract float PagarImposto(float rendimento);
        
    }
}