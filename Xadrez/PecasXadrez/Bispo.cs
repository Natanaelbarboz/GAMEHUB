using JOGOSHUB.JogoDaVelha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace JOGOSHUB.Xadrez.PecasXadrez;
class Bispo : Tabuleiro.Peca
{

    public Bispo(Tabuleiro.Tabuleiro tab, Tabuleiro.Cor cor) : base(tab, cor)
    {
    }

    public override string ToString()
    {
        return "B";
    }

    private bool podeMover(Tabuleiro.Posicao pos)
    {
        Tabuleiro.Peca p = tab.peca(pos);
        return p == null || p.cor != cor;
    }

    public override bool[,] movimentosPossiveis()
    {
        bool[,] mat = new bool[tab.linhas, tab.colunas];

        Tabuleiro.Posicao pos = new Tabuleiro.Posicao(0, 0);

        // NO
        pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
        while (tab.posicaoValida(pos) && podeMover(pos))
        {
            mat[pos.linha, pos.coluna] = true;
            if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
            {
                break;
            }
            pos.definirValores(pos.linha - 1, pos.coluna - 1);
        }

        // NE
        pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
        while (tab.posicaoValida(pos) && podeMover(pos))
        {
            mat[pos.linha, pos.coluna] = true;
            if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
            {
                break;
            }
            pos.definirValores(pos.linha - 1, pos.coluna + 1);
        }

        // SE
        pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
        while (tab.posicaoValida(pos) && podeMover(pos))
        {
            mat[pos.linha, pos.coluna] = true;
            if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
            {
                break;
            }
            pos.definirValores(pos.linha + 1, pos.coluna + 1);
        }

        // SO
        pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
        while (tab.posicaoValida(pos) && podeMover(pos))
        {
            mat[pos.linha, pos.coluna] = true;
            if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
            {
                break;
            }
            pos.definirValores(pos.linha + 1, pos.coluna - 1);
        }

        return mat;
    }
}

