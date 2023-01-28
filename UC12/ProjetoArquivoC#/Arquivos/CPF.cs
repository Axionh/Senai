// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using Arquivos;

namespace CPF
{
    public class CPF
    {
        public static bool temCPF(bool CPFF)
        {

            try
            {   
                Console.WriteLine("Cliente é pessoa física? Digite true ou false. ");
                CPFF=Convert.ToBoolean(Console.ReadLine());
                Program.eCPF=CPFF;
                return CPFF;
            }
            catch (Exception)
            {
                Console.WriteLine("Erro. Digite true ou false.");
                CPFF=false;
                temCPF(CPFF);
                return CPFF;
                
            }

        }
        public static long CPFnumero(bool CPFF1, long CPFFnumeracao=0)
        {
            try
            {
                if (CPFF1==true)

                {   
                    Console.WriteLine("Digite o CPF");
                    CPFFnumeracao=Convert.ToInt64(Console.ReadLine());

                }else
                {
                    Console.WriteLine("Digite o CPNJ");
                    CPFFnumeracao=Convert.ToInt64(Console.ReadLine());
                }
            
            Program.eCPFnumber=CPFFnumeracao;

            return CPFFnumeracao;

            }
            catch (Exception)
            {
                Console.WriteLine("Erro. Digite um número válido.");
                CPFFnumeracao=0;
                CPFnumero(CPFF1);
                return CPFFnumeracao;
            }
        }
        
    }

} 

