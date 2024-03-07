using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "T";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            //bool ehPecaAdversaria = p.Cor != Cor;
            //bool ehCasaVazia = p == null;
            //return ehCasaVazia || ehPecaAdversaria;
            return p == null || p.Cor != Cor;
        }
        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);
            

            //acima
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (Tab.PosicaoValida(pos) && podeMover(pos))
            {
                bool existePecaAdversaria = Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor;
                mat[pos.Linha, pos.Coluna] = true;
                if (existePecaAdversaria)
                {
                    break;
                }
                pos.Linha = pos.Linha - 1;
            }

            //abaixo
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tab.PosicaoValida(pos) && podeMover(pos))
            {
                bool existePecaAdversaria = Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor;
                mat[pos.Linha, pos.Coluna] = true;
                if (existePecaAdversaria)
                {
                    break;
                }
                pos.Linha = pos.Linha + 1;
            }

            //direita
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna +1);
            while (Tab.PosicaoValida(pos) && podeMover(pos))
            {
                bool existePecaAdversaria = Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor;
                mat[pos.Linha, pos.Coluna] = true;
                if (existePecaAdversaria)
                {
                    break;
                }
                pos.Coluna = pos.Coluna + 1;
            }

            //esquerda
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && podeMover(pos))
            {
                bool existePecaAdversaria = Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor;
                mat[pos.Linha, pos.Coluna] = true;
                if (existePecaAdversaria)
                {
                    break;
                }
                pos.Coluna = pos.Coluna - 1;
            }

            return mat;
        }
    }
}
