using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez;


namespace Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //PosicaoXadrez P = new PosicaoXadrez('c', 7);
            //Console.WriteLine(P);

            //Console.WriteLine(P.ToPosicao());
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();


                Tela.ImprimirTabuleiro(partida.tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();
        }
    }
}
