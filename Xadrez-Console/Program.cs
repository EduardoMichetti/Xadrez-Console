﻿using System;
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
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 0));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 0));

                tab.colocarPeca(new Torre(tab, Cor.Verde), new Posicao(1, 1));
                tab.colocarPeca(new Torre(tab, Cor.Azul), new Posicao(2, 1));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(3, 1));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();
        }
    }
}
