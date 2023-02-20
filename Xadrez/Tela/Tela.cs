using JOGOSHUB.Xadrez.PecasXadrez;
using JOGOSHUB.Xadrez.Tabuleiro;
using JOGOSHUB.JogoDaVelha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JOGOSHUB.Jogadores;

namespace JOGOSHUB.Xadrez.Tela
{
    class Tela
    {

        public static void imprimirPartida(PartidaDeXadrez partida)
        {
            imprimirTabuleiro(partida.tab);
            Console.WriteLine();
            imprimirPecasCapturadas(partida);
            Console.WriteLine();
            //Console.WriteLine("Turno: " + partida.turno);
            if (!partida.terminada)
            {
                Console.WriteLine($"Jogador atual: {partida.JogadorAtualNome}");
                Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);
                if (partida.xeque)
                {
                    Console.WriteLine("XEQUE!");
                }
            }
            else
            {
                Console.WriteLine("XEQUEMATE!");
                Console.WriteLine("Vencedor: " + partida.JogadorAtualNome);
                Console.WriteLine("Vencedor: " + partida.jogadorAtual);

                ManipulandoJson.DeserealizarJogador();

                foreach (Jogadores.Jogadores jog in Jogadores.Jogadores.Jogador)
                {
                    if (jog.Nome == partida.JogadorAtualNome)
                    {
                        Console.WriteLine($"Parabéns {jog.Nome}, você acaba de ganhar mais um ponto!!");
                        jog.Pontuacao++;
                        Console.WriteLine($"Sua pontuação atual é de {jog.Pontuacao} ponto(s)");
                        //Jogadores.Jogadores.Jogador.Add(new Jogadores.Jogadores(jog.Nome, jog.Senha, jog.Pontuacao));
                        break;
                    }
                }
                ManipulandoJson.SerealizarJogador();

            }
        }

        public static void imprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine("Peças capturadas:");
            Console.Write("Brancas: ");
            imprimirConjunto(partida.pecasCapturadas(Cor.Branca));
            Console.WriteLine();
            Console.Write("Pretas: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            imprimirConjunto(partida.pecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux;
            Console.WriteLine();
        }

        public static void imprimirConjunto(HashSet<Peca> conjunto)
        {
            Console.Write("[");
            foreach (Peca x in conjunto)
            {
                Console.Write(x + " ");
            }
            Console.Write("]");
        }

        public static void imprimirTabuleiro(Tabuleiro.Tabuleiro tab)
        {

            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + "  ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    imprimirPeca(tab.peca(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n     A    B    C    D    E    F    G    H");
        }

        public static void imprimirTabuleiro(Tabuleiro.Tabuleiro tab, bool[,] posicoePossiveis)
        {

            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (posicoePossiveis[i, j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    imprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("     A    B    C    D    E    F    G    H");
            Console.BackgroundColor = fundoOriginal;
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void imprimirPeca(Peca peca)
        {

            if (peca == null)
            {
                Console.Write("| - |");
            }
            else
            {
                if (peca.cor == Cor.Branca)
                {
                    Console.Write($"| {peca} |");
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"| {peca} |");
                    Console.ForegroundColor = aux;
                }
                Console.Write("");
            }
        }

    }
}
