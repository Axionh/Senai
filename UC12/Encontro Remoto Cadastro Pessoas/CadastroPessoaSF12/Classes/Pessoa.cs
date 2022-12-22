using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroPessoaSF12.Interfaces;

namespace CadastroPessoaSF12.Classes
{
    public abstract class Pessoa : IPessoa 

    {        //atributos
        public string ?Nome {get;set;} //o ponto de interrogacao permite o valor nulo

        public Endereco ?Endereco {get;set;}

        public float Rendimento {get;set;}

        public abstract float PagarImposto(float rendimento);
        
    }
}