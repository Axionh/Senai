using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoaSF12.Interfaces
{
    public interface IPessoa
    {
        float PagarImposto (float rendimento); //interface apenas é um método sem implementação e recebe o rendimento
    }
}