using JOGOSHUB.Jogadores;
using JOGOSHUB.Xadrez.Tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace JOGOSHUB.Xadrez.PecasXadrez
{
    class PartidaDeXadrez
    {

        public Tabuleiro.Tabuleiro tab { get; private set; }
        public int turno { get; private set; }
        public Cor jogadorAtual { get; private set; }
        public static int resultadoSorteio { get; set; }
        public string JogadorAtualNome { get; private set; }
        public bool terminada { get; private set; }
        private HashSet<Peca> pecas;
        private HashSet<Peca> capturadas;
        public bool xeque { get; private set; }
        public Peca vulneravelEnPassant { get; private set; }

        public PartidaDeXadrez()
        {
            resultadoSorteio = ImparPar.ResultadoSorteio;
            if (resultadoSorteio % 2 == 0) { JogadorAtualNome = ImparPar.Par; }
            else { JogadorAtualNome = ImparPar.Impar; }

            tab = new Tabuleiro.Tabuleiro(8, 8);
            //turno = 1;
            turno = resultadoSorteio;
            jogadorAtual = Cor.Branca;
            terminada = false;
            xeque = false;
            vulneravelEnPassant = null;
            pecas = new HashSet<Tabuleiro.Peca>();
            capturadas = new HashSet<Tabuleiro.Peca>();
            colocarPecas();
        }

        public Tabuleiro.Peca executaMovimento(Tabuleiro.Posicao origem, Tabuleiro.Posicao destino)
        {
            Tabuleiro.Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            Tabuleiro.Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
            if (pecaCapturada != null)
            {
                capturadas.Add(pecaCapturada);
            }

            // #jogadaespecial roque pequeno
            if (p is Rei && destino.coluna == origem.coluna + 2)
            {
                Tabuleiro.Posicao origemT = new Tabuleiro.Posicao(origem.linha, origem.coluna + 3);
                Tabuleiro.Posicao destinoT = new Tabuleiro.Posicao(origem.linha, origem.coluna + 1);
                Tabuleiro.Peca T = tab.retirarPeca(origemT);
                T.incrementarQteMovimentos();
                tab.colocarPeca(T, destinoT);
            }

            // #jogadaespecial roque grande
            if (p is Rei && destino.coluna == origem.coluna - 2)
            {
                Tabuleiro.Posicao origemT = new Tabuleiro.Posicao(origem.linha, origem.coluna - 4);
                Tabuleiro.Posicao destinoT = new Tabuleiro.Posicao(origem.linha, origem.coluna - 1);
                Tabuleiro.Peca T = tab.retirarPeca(origemT);
                T.incrementarQteMovimentos();
                tab.colocarPeca(T, destinoT);
            }

            // #jogadaespecial en passant
            if (p is Peao)
            {
                if (origem.coluna != destino.coluna && pecaCapturada == null)
                {
                    Tabuleiro.Posicao posP;
                    if (p.cor == Tabuleiro.Cor.Branca)
                    {
                        posP = new Tabuleiro.Posicao(destino.linha + 1, destino.coluna);
                    }
                    else
                    {
                        posP = new Tabuleiro.Posicao(destino.linha - 1, destino.coluna);
                    }
                    pecaCapturada = tab.retirarPeca(posP);
                    capturadas.Add(pecaCapturada);
                }
            }

            return pecaCapturada;
        }

        public void desfazMovimento(Tabuleiro.Posicao origem, Tabuleiro.Posicao destino, Tabuleiro.Peca pecaCapturada)
        {
            Tabuleiro.Peca p = tab.retirarPeca(destino);
            p.decrementarQteMovimentos();
            if (pecaCapturada != null)
            {
                tab.colocarPeca(pecaCapturada, destino);
                capturadas.Remove(pecaCapturada);
            }
            tab.colocarPeca(p, origem);

            // #jogadaespecial roque pequeno
            if (p is Rei && destino.coluna == origem.coluna + 2)
            {
                Tabuleiro.Posicao origemT = new Tabuleiro.Posicao(origem.linha, origem.coluna + 3);
                Tabuleiro.Posicao destinoT = new Tabuleiro.Posicao(origem.linha, origem.coluna + 1);
                Tabuleiro.Peca T = tab.retirarPeca(destinoT);
                T.decrementarQteMovimentos();
                tab.colocarPeca(T, origemT);
            }

            // #jogadaespecial roque grande
            if (p is Rei && destino.coluna == origem.coluna - 2)
            {
                Tabuleiro.Posicao origemT = new Tabuleiro.Posicao(origem.linha, origem.coluna - 4);
                Tabuleiro.Posicao destinoT = new Tabuleiro.Posicao(origem.linha, origem.coluna - 1);
                Tabuleiro.Peca T = tab.retirarPeca(destinoT);
                T.decrementarQteMovimentos();
                tab.colocarPeca(T, origemT);
            }

            // #jogadaespecial en passant
            if (p is Peao)
            {
                if (origem.coluna != destino.coluna && pecaCapturada == vulneravelEnPassant)
                {
                    Tabuleiro.Peca peao = tab.retirarPeca(destino);
                    Tabuleiro.Posicao posP;
                    if (p.cor == Tabuleiro.Cor.Branca)
                    {
                        posP = new Tabuleiro.Posicao(3, destino.coluna);
                    }
                    else
                    {
                        posP = new Tabuleiro.Posicao(4, destino.coluna);
                    }
                    tab.colocarPeca(peao, posP);
                }
            }
        }

        public void realizaJogada(Tabuleiro.Posicao origem, Tabuleiro.Posicao destino)
        {
            Tabuleiro.Peca pecaCapturada = executaMovimento(origem, destino);

            if (estaEmXeque(jogadorAtual))
            {
                desfazMovimento(origem, destino, pecaCapturada);
                throw new Tabuleiro.TabuleiroException("Você não pode se colocar em xeque!");
            }

            Tabuleiro.Peca p = tab.peca(destino);

            // #jogadaespecial promocao
            if (p is Peao)
            {
                if (p.cor == Tabuleiro.Cor.Branca && destino.linha == 0 || p.cor == Tabuleiro.Cor.Preta && destino.linha == 7)
                {
                    p = tab.retirarPeca(destino);
                    pecas.Remove(p);
                    Tabuleiro.Peca dama = new Dama(tab, p.cor);
                    tab.colocarPeca(dama, destino);
                    pecas.Add(dama);
                }
            }

            if (estaEmXeque(adversaria(jogadorAtual)))
            {
                xeque = true;
            }
            else
            {
                xeque = false;
            }

            if (testeXequemate(adversaria(jogadorAtual)))
            {
                terminada = true;
            }
            else
            {
                turno++;
                mudaJogador();
            }

            // #jogadaespecial en passant
            if (p is Peao && (destino.linha == origem.linha - 2 || destino.linha == origem.linha + 2))
            {
                vulneravelEnPassant = p;
            }
            else
            {
                vulneravelEnPassant = null;
            }

        }

        public void validarPosicaoDeOrigem(Tabuleiro.Posicao pos)
        {
            if (tab.peca(pos) == null)
            {
                throw new Tabuleiro.TabuleiroException("Não existe peça na posição de origem escolhida!");
            }
            if (jogadorAtual != tab.peca(pos).cor)
            {
                throw new Tabuleiro.TabuleiroException("A peça de origem escolhida não é sua!");
            }
            if (!tab.peca(pos).existeMovimentosPossiveis())
            {
                throw new Tabuleiro.TabuleiroException("Não há movimentos possíveis para a peça de origem escolhida!");
            }
        }

        public void validarPosicaoDeDestino(Tabuleiro.Posicao origem, Tabuleiro.Posicao destino)
        {
            if (!tab.peca(origem).movimentoPossivel(destino))
            {
                throw new Tabuleiro.TabuleiroException("Posição de destino inválida!");
            }
        }


         private void mudaJogador()
        {
            if (turno % 2 == 0)
            {
                jogadorAtual = Tabuleiro.Cor.Preta;
                JogadorAtualNome = ImparPar.Par;
            }
            else
            {
                jogadorAtual = Tabuleiro.Cor.Branca;
                JogadorAtualNome = ImparPar.Impar;
            }
        }

        public HashSet<Tabuleiro.Peca> pecasCapturadas(Tabuleiro.Cor cor)
        {
            HashSet<Tabuleiro.Peca> aux = new HashSet<Tabuleiro.Peca>();
            foreach (Tabuleiro.Peca x in capturadas)
            {
                if (x.cor == cor)
                {
                    aux.Add(x);
                }
            }
            return aux;
        }

        public HashSet<Tabuleiro.Peca> pecasEmJogo(Tabuleiro.Cor cor)
        {
            HashSet<Tabuleiro.Peca> aux = new HashSet<Tabuleiro.Peca>();
            foreach (Tabuleiro.Peca x in pecas)
            {
                if (x.cor == cor)
                {
                    aux.Add(x);
                }
            }
            aux.ExceptWith(pecasCapturadas(cor));
            return aux;
        }

        private Tabuleiro.Cor adversaria(Tabuleiro.Cor cor)
        {
            if (cor == Tabuleiro.Cor.Branca)
            {
                return Tabuleiro.Cor.Preta;
            }
            else
            {
                return Tabuleiro.Cor.Branca;
            }
        }

        private Tabuleiro.Peca rei(Tabuleiro.Cor cor)
        {
            foreach (Tabuleiro.Peca x in pecasEmJogo(cor))
            {
                if (x is Rei)
                {
                    return x;
                }
            }
            return null;
        }

        public bool estaEmXeque(Tabuleiro.Cor cor)
        {
            Tabuleiro.Peca R = rei(cor);
            if (R == null)
            {
                throw new Tabuleiro.TabuleiroException("Não tem rei da cor " + cor + " no tabuleiro!");
            }
            foreach (Tabuleiro.Peca x in pecasEmJogo(adversaria(cor)))
            {
                bool[,] mat = x.movimentosPossiveis();
                if (mat[R.posicao.linha, R.posicao.coluna])
                {
                    return true;
                }
            }
            return false;
        }

        public bool testeXequemate(Tabuleiro.Cor cor)
        {
            if (!estaEmXeque(cor))
            {
                return false;
            }
            foreach (Tabuleiro.Peca x in pecasEmJogo(cor))
            {
                bool[,] mat = x.movimentosPossiveis();
                for (int i = 0; i < tab.linhas; i++)
                {
                    for (int j = 0; j < tab.colunas; j++)
                    {
                        if (mat[i, j])
                        {
                            Tabuleiro.Posicao origem = x.posicao;
                            Tabuleiro.Posicao destino = new Tabuleiro.Posicao(i, j);
                            Tabuleiro.Peca pecaCapturada = executaMovimento(origem, destino);
                            bool testeXeque = estaEmXeque(cor);
                            desfazMovimento(origem, destino, pecaCapturada);
                            if (!testeXeque)
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        public void colocarNovaPeca(char coluna, int linha, Tabuleiro.Peca peca)
        {
            tab.colocarPeca(peca, new PosicaoXadrez(coluna, linha).toPosicao());
            pecas.Add(peca);
        }

        private void colocarPecas()
        {
            //colocarNovaPeca('a', 1, new Torre(tab, Cor.Branca));
            colocarNovaPeca('a', 1, new Torre(tab, Cor.Branca));
            colocarNovaPeca('b', 1, new Cavalo(tab, Cor.Branca));
            colocarNovaPeca('c', 1, new Bispo(tab, Cor.Branca));
            colocarNovaPeca('d', 1, new Dama(tab, Cor.Branca));
            colocarNovaPeca('e', 1, new Rei(tab, Cor.Branca, this));
            colocarNovaPeca('f', 1, new Bispo(tab, Cor.Branca));
            colocarNovaPeca('g', 1, new Cavalo(tab, Cor.Branca));
            colocarNovaPeca('h', 1, new Torre(tab, Cor.Branca));
            colocarNovaPeca('a', 2, new Peao(tab, Cor.Branca, this));
            colocarNovaPeca('b', 2, new Peao(tab, Cor.Branca, this));
            colocarNovaPeca('c', 2, new Peao(tab, Cor.Branca, this));
            colocarNovaPeca('d', 2, new Peao(tab, Cor.Branca, this));
            colocarNovaPeca('e', 2, new Peao(tab, Cor.Branca, this));
            colocarNovaPeca('f', 2, new Peao(tab, Cor.Branca, this));
            colocarNovaPeca('g', 2, new Peao(tab, Cor.Branca, this));
            colocarNovaPeca('h', 2, new Peao(tab, Cor.Branca, this));

            colocarNovaPeca('a', 8, new Torre(tab, Cor.Preta));
            colocarNovaPeca('b', 8, new Cavalo(tab, Cor.Preta));
            colocarNovaPeca('c', 8, new Bispo(tab, Cor.Preta));
            colocarNovaPeca('d', 8, new Dama(tab, Cor.Preta));
            colocarNovaPeca('e', 8, new Rei(tab, Cor.Preta, this));
            colocarNovaPeca('f', 8, new Bispo(tab, Cor.Preta));
            colocarNovaPeca('g', 8, new Cavalo(tab, Cor.Preta));
            colocarNovaPeca('h', 8, new Torre(tab, Cor.Preta));
            colocarNovaPeca('a', 7, new Peao(tab, Cor.Preta, this));
            colocarNovaPeca('b', 7, new Peao(tab, Cor.Preta, this));
            colocarNovaPeca('c', 7, new Peao(tab, Cor.Preta, this));
            colocarNovaPeca('d', 7, new Peao(tab, Cor.Preta, this));
            colocarNovaPeca('e', 7, new Peao(tab, Cor.Preta, this));
            colocarNovaPeca('f', 7, new Peao(tab, Cor.Preta, this));
            colocarNovaPeca('g', 7, new Peao(tab, Cor.Preta, this));
            colocarNovaPeca('h', 7, new Peao(tab, Cor.Preta, this));
        }
    }
}
