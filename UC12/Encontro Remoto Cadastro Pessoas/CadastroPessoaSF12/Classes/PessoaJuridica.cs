using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroPessoaSF12.Interfaces;
using System.Text.RegularExpressions; //importação RegEx

namespace CadastroPessoaSF12.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {//atributos
        public string? Cnpj { get; set; }

        public string? Razaosocial { get; set; }
        public string? Fantasia { get; set; }


        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {
            //implementação do método para receber o CNPJ e validar o mesmo 
            //62.236.353/0001-42        18digitos
            //62236353000142            14digitos
            //Verificar se tem o 0001

            if (Regex.IsMatch(cnpj, @"^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$")) //primeiro padrao
            {
                if (cnpj.Length == 18)
                {//18 digitos
                    if (cnpj.Substring(11, 4) =="0001")
                    {//0001
                        return true;
                    }
                }
                else if (cnpj.Length == 14)
                {//14 digitos
                    if (cnpj.Substring(8, 4) =="0001")
                    {//0001
                        return true;
                    }
                }
            }
                return false;
        }
    }
}
    