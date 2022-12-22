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



        //PESSOA FÍSICA regra de descontos
        //Para rendimentos até R$ 5.000,00 - desconto de 6%
        //Para rendimentos entre R$ 5.000,01 e R$ 10.000,00 - desconto de 8%
        //Para rendimentos acima R$ 10.00,01 - desconto de 10%
        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 5000)
            {
                return rendimento - (rendimento / 100 * 6);
            }
            else if (rendimento <= 10000)
            {//desconto de 8% acima de 5000 e ate 10000
                return rendimento - (rendimento / 100 * 8);
            }
            else
            {//desconto de 10% acima de 10000
                return rendimento - (rendimento / 100 * 10);
            }
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
                    if (cnpj.Substring(11, 4) == "0001")
                    {//0001
                        return true;
                    }
                }
                else if (cnpj.Length == 14)
                {//14 digitos
                    if (cnpj.Substring(8, 4) == "0001")
                    {//0001
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
