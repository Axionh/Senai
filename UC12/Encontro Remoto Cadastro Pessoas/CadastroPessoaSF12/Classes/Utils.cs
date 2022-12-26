using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoaSF12.Classes
{
    public static class Utils
    {
        public static void Loading(string texto, int qtdPontos, int tempo)//uso o static por nao ser instanciavel
        {
            //Loading
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write(texto);
            //laço de repetição
            for (int i = 1; i <= qtdPontos; i++)
            {
                Console.Write($".");
                Thread.Sleep(tempo);
            };
            Console.ResetColor(); //reseta a cor do backgroundcolor e da fonte
            Console.WriteLine(); //pular linha
        }

        public static void ParadaNoConsole(string texto, ConsoleColor corFonte = ConsoleColor.White)
        {
              Console.ForegroundColor = corFonte;
            Console.WriteLine(texto, corFonte);
            Console.WriteLine($"Tecle <ENTER> para continuar");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}