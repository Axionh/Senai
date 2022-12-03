using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoaSF12.Interfaces
{
    public interface IPessoaFisica
    {
      //nome do metodo sera ValidarDataNascimento
      //argumento de entrada desse metodo sera data de nascimento
      //retorna um booleano, verdadeiro ou falso 

      public bool ValidarDataNascimento(DateTime dataNasc);
    }
}