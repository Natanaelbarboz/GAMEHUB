using JOGOSHUB.Jogadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOGOSHUB.JogoDaVelha
{
    class ExecutarJogoDaVelha
    {
        public static void Jogo()
        {

            ImparPar jogoImparPar = new ImparPar();

            //Console.WriteLine($"Este é o PAR {ImparPar.Par}");
            //Console.WriteLine($"Este é o IMPAR {ImparPar.Impar}");

            string[,] mat = new string[3, 3];
            mat = ImparPar.Mat;


            ValidacaoJogadas validacaoVelha = new ValidacaoJogadas();

            //int mostrarLinha = 1;
            int contador = ImparPar.ResultadoSorteio;


            string entradaOpcoes;
            string jogadorDaVez;



            Tabuleiro.Tab();


            while (true)
            {

                //Console.WriteLine($"\nContador De Jogadas: {contador}\n");

                if (contador % 2 == 0)
                {
                    Console.WriteLine($"{ImparPar.Par} é sua vez de jogar");
                    jogadorDaVez = ImparPar.Par;
                    entradaOpcoes = "X";


                }
                else
                {
                    Console.WriteLine($"{ImparPar.Impar} é sua vez de jogar: ");
                    jogadorDaVez = ImparPar.Impar;
                    entradaOpcoes = "O";

                }

                Console.Write($"{jogadorDaVez} digite a posição que deseja inserir: ");
                int posicao = int.Parse(Console.ReadLine());

                while (!(posicao >= 1 && posicao <= 9))
                {
                    Console.WriteLine("Opção inválida");
                    Console.Write("Digite a posição que deseja inserir: ");
                    posicao = int.Parse(Console.ReadLine());

                    continue;

                }

                if (posicao >= 1 && posicao <= 3)
                {
                    if (mat[0, posicao - 1] != null)
                    {
                        Console.WriteLine("Essa posição já foi preenchida, digite novamente");
                        continue;
                    }

                    mat[0, posicao - 1] = " " + entradaOpcoes + " ";
                    contador++;
                    ImparPar.Contador++;
                }
                else if (posicao >= 4 && posicao <= 6)
                {
                    if (mat[1, posicao - 4] != null)
                    {
                        Console.WriteLine("Essa posição já foi preenchida, digite novamente");
                        continue;
                    }

                    mat[1, posicao - 4] = " " + entradaOpcoes + " ";
                    contador++;
                    ImparPar.Contador++;


                }
                else if (posicao >= 7 && posicao <= 9)
                {
                    if (mat[2, posicao - 7] != null)
                    {
                        Console.WriteLine("Essa posição já foi preenchida, digite novamente");
                        continue;
                    }
                    mat[2, posicao - 7] = " " + entradaOpcoes + " ";
                    contador++;
                    ImparPar.Contador++;

                }

                Console.WriteLine();
                for (int linha = 0; linha < mat.GetLength(0); linha++)
                {
                    //Console.Write(0 + linha);
                    for (int coluna = 0; coluna < mat.GetLongLength(1); coluna++)
                    {
                        if (mat[linha, coluna] == null)
                        {
                            Console.Write(" - ");
                        }
                        else
                        {
                            Console.Write(mat[linha, coluna]);
                        }
                    }
                    Console.WriteLine();
                }

                validacaoVelha.Validacao();
                if (validacaoVelha.Validacao() == 1)
                {
                    ManipulandoJson.DeserealizarJogador();

                    Console.WriteLine($"{jogadorDaVez}, você venceu o jogo");

                    foreach (Jogadores.Jogadores jog in Jogadores.Jogadores.Jogador)
                    {
                        if (jog.Nome == jogadorDaVez)
                        {

                            Console.WriteLine($"Parabéns {jog.Nome}, você acaba de ganhar mais um ponto!!");
                            jog.Pontuacao++;
                            Console.WriteLine($"Sua pontuação atual é de {jog.Pontuacao} ponto(s)");
                            //Jogadores.Jogadores.Jogador.Add(new Jogadores.Jogadores(jog.Nome, jog.Senha, jog.Pontuacao));
                            break;
                        }
                    }
                    ManipulandoJson.SerealizarJogador();
                    break;
                }
                else if (validacaoVelha.Validacao() == 3)
                {
                    Console.WriteLine($"Deu velha!");
                    break;
                }

                Tabuleiro.Tab();

            }
            /*
            int novoJogo;

            do
            {

                Console.WriteLine("Deseja jogar novamente? ");
                Console.WriteLine("1 - Sim || 2 - Não");
                Console.Write("Selecione uma das opções acima: ");
                novoJogo = int.Parse(Console.ReadLine());

                Array.Clear(ImparPar.Mat, 0, ImparPar.Mat.Length);
                ImparPar.Contador = 0;
                contador = 0;


                if (novoJogo == 1)
                {
                    Console.Clear();
                    ImparPar.ExecutarJogoVelha();
                }

            } while (novoJogo == 1);
            */

        }






    }
}
