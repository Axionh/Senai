// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using CPF;

namespace Arquivos
{
    public class Program
    {

        public static bool eCPF {get; set;}
        public static string eCPFtype{get; set;}="";

        private static long _eCPFnumber;
        public static long eCPFnumber
        {
            get {return eCPFnumber;}
            set {_eCPFnumber=value;}
        }
        public static string nome{get; set;}="";

        public static async Task Main(string[] args)
        {

            List<string> lines=new List<string>();
            List<string> texto=new List<string>();            
            var nome="";

            for (var i=0; i<10; i++)
            {
                {
                    CPF.CPF.temCPF(eCPF);
                    CPF.CPF.CPFnumero(eCPF);
    
                    if (eCPF==true)
                    {
                        eCPFtype="CPF";
                    }else
                    {
                        eCPFtype="CPNJ";
                    }

                    Console.WriteLine("Digite o nome do cliente...");
                    lines.Add(Convert.ToString(nome = (Console.ReadLine())+", Tipo de pessoa: "+eCPFtype+", Numeração: "+_eCPFnumber));
                    Console.WriteLine("Cliente adicionado!!! Nome: "+lines[i]);

                    await File.WriteAllLinesAsync("arquivo.txt", lines);
                }       
            }
        }
    
    }
}    

