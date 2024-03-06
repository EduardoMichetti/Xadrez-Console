using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    internal class Tela
    {
        public  static void ImprimirTabuleiro (Tabuleiro tab) 
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.Peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        //Console.Write(tab.Peca(i, j) + " ");
                        //Alterado para metodo que altera cor
                        ImprimirPeca(tab.Peca(i, j));
                        Console.Write(" ");


                    }
                }
                Console.WriteLine();
            }
            Console.Write("  a b c d e f g h");
        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);       
        }

        public static void ImprimirPeca(Peca peca)
        {
            //ALTERADO A LÓGICA INICIAL PARA CONTEMPLAR MAIS CORES
            ConsoleColor aux = Console.ForegroundColor;
            if (peca.Cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else if (peca.Cor == Cor.Preta)
            {                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
            else if (peca.Cor == Cor.Verde)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
            else if (peca.Cor == Cor.Azul)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
            else
            {//PARA MANTER A BRANCA QUANDO NÃO HOUVER A COR
                //ConsoleColor aux = Console.ForegroundColor;
                //Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                //Console.ForegroundColor = aux;
            }
        }
    }
}
