using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Posicao P;
            //P = new Posicao(3, 4);
            //Console.WriteLine("Posição: " + P.Linha);

            Tabuleiro tab = new Tabuleiro(8,8);

            Tela.ImprimirTabuleiro(tab);



            Console.ReadLine();
        }
    }
}
