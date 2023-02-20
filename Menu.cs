using JOGOSHUB.Jogadores;
using JOGOSHUB.JogoDaVelha;
using JOGOSHUB.Xadrez.Tela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOGOSHUB
{
    class Menu
    {

        public static void MenuJogos()
        {

            Console.WriteLine(" _______  _______  __   __    __   __  ___   __    _  ______   _______ \r\n|  _    ||       ||  |_|  |  |  | |  ||   | |  |  | ||      | |       |\r\n| |_|   ||    ___||       |  |  |_|  ||   | |   |_| ||  _    ||   _   |\r\n|       ||   |___ |       |  |       ||   | |       || | |   ||  | |  |\r\n|  _   | |    ___||       |  |       ||   | |  _    || |_|   ||  |_|  |\r\n| |_|   ||   |___ | ||_|| |   |     | |   | | | |   ||       ||       |\r\n|_______||_______||_|   |_|    |___|  |___| |_|  |__||______| |_______|\r\n                       _______  _______                                \r\n                      |   _   ||       |                               \r\n                      |  |_|  ||   _   |                               \r\n                      |       ||  | |  |                               \r\n                      |       ||  |_|  |                               \r\n                      |   _   ||       |                               \r\n                      |__| |__||_______|                               \r\n _______  _______  __   __  _______  __   __  __   __  _______         \r\n|       ||   _   ||  |_|  ||       ||  | |  ||  | |  ||  _    |        \r\n|    ___||  |_|  ||       ||    ___||  |_|  ||  | |  || |_|   |        \r\n|   | __ |       ||       ||   |___ |       ||  |_|  ||       |        \r\n|   ||  ||       ||       ||    ___||       ||       ||  _   |         \r\n|   |_| ||   _   || ||_|| ||   |___ |   _   ||       || |_|   |        \r\n|_______||__| |__||_|   |_||_______||__| |__||_______||_______|        ");
            Console.WriteLine("\n\nJogador 1º - Selecione uma das opções abaixo\n");
            Console.WriteLine("1 - ENTRAR COM USUÁRIO\n2 - CADASTRAR USUÁRIO\n3 - JOGAR SEM CADASTRO  ");

            Console.Write("\nInforme a opção desejada: ");
            string entradaJogador1 = Console.ReadLine();
            while (entradaJogador1 != "1" && entradaJogador1 != "2" && entradaJogador1 != "3")
            {
                Console.WriteLine("Entrada inválida");
                Console.WriteLine("Selecione uma das opções abaixo\n");
                Console.WriteLine("1 - ENTRAR COM USUÁRIO\n2 - CADASTRAR USUÁRIO\n3 - JOGAR SEM CADASTRO");
                Console.Write("\nInforme a opção desejada: ");
                entradaJogador1 = Console.ReadLine();
            }

            switch (entradaJogador1)
            {
                case "1":
                    Jogadores.Jogadores.JogadorUm();
                    break;
                case "2":
                    Jogadores.Jogadores.CadastroJogadorUm();
                    break;
                case "3":
                    Jogadores.Jogadores.SemRegistroJogadorUm();
                    break;

            }

            Console.WriteLine("\nPara continuar aperte qualquer tecla.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(" _______  _______  __   __    __   __  ___   __    _  ______   _______ \r\n|  _    ||       ||  |_|  |  |  | |  ||   | |  |  | ||      | |       |\r\n| |_|   ||    ___||       |  |  |_|  ||   | |   |_| ||  _    ||   _   |\r\n|       ||   |___ |       |  |       ||   | |       || | |   ||  | |  |\r\n|  _   | |    ___||       |  |       ||   | |  _    || |_|   ||  |_|  |\r\n| |_|   ||   |___ | ||_|| |   |     | |   | | | |   ||       ||       |\r\n|_______||_______||_|   |_|    |___|  |___| |_|  |__||______| |_______|\r\n                       _______  _______                                \r\n                      |   _   ||       |                               \r\n                      |  |_|  ||   _   |                               \r\n                      |       ||  | |  |                               \r\n                      |       ||  |_|  |                               \r\n                      |   _   ||       |                               \r\n                      |__| |__||_______|                               \r\n _______  _______  __   __  _______  __   __  __   __  _______         \r\n|       ||   _   ||  |_|  ||       ||  | |  ||  | |  ||  _    |        \r\n|    ___||  |_|  ||       ||    ___||  |_|  ||  | |  || |_|   |        \r\n|   | __ |       ||       ||   |___ |       ||  |_|  ||       |        \r\n|   ||  ||       ||       ||    ___||       ||       ||  _   |         \r\n|   |_| ||   _   || ||_|| ||   |___ |   _   ||       || |_|   |        \r\n|_______||__| |__||_|   |_||_______||__| |__||_______||_______|        ");
            Console.WriteLine("\n\nJogador 2º - Selecione uma das opções abaixo\n");
            Console.WriteLine("1 - ENTRAR COM USUÁRIO\n2 - CADASTRAR USUÁRIO\n3 - JOGAR SEM CADASTRO  ");
            string entradaJogador2 = Console.ReadLine();
            while (entradaJogador2 != "1" && entradaJogador2 != "2" && entradaJogador2 != "3")
            {
                Console.WriteLine("Entrada inválida");
                Console.WriteLine("Selecione uma das opções abaixo\n");
                Console.WriteLine("1 - ENTRAR COM USUÁRIO\n2 - CADASTRAR USUÁRIO\n3 - JOGAR SEM CADASTRO  ");
                Console.Write("\nInforme a opção desejada: ");
                entradaJogador2 = Console.ReadLine();
            }

            switch (entradaJogador2)
            {
                case "1":
                    Jogadores.Jogadores.JogadorDois();
                    break;
                case "2":
                    Jogadores.Jogadores.CadastroJogadorDois();
                    break;
                case "3":
                    Jogadores.Jogadores.SemRegistroJogadorDois();
                    break;

            }
            Console.WriteLine("\nPara continuar aperte qualquer tecla.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(" _______  _______  __   __    __   __  ___   __    _  ______   _______ \r\n|  _    ||       ||  |_|  |  |  | |  ||   | |  |  | ||      | |       |\r\n| |_|   ||    ___||       |  |  |_|  ||   | |   |_| ||  _    ||   _   |\r\n|       ||   |___ |       |  |       ||   | |       || | |   ||  | |  |\r\n|  _   | |    ___||       |  |       ||   | |  _    || |_|   ||  |_|  |\r\n| |_|   ||   |___ | ||_|| |   |     | |   | | | |   ||       ||       |\r\n|_______||_______||_|   |_|    |___|  |___| |_|  |__||______| |_______|\r\n                       _______  _______                                \r\n                      |   _   ||       |                               \r\n                      |  |_|  ||   _   |                               \r\n                      |       ||  | |  |                               \r\n                      |       ||  |_|  |                               \r\n                      |   _   ||       |                               \r\n                      |__| |__||_______|                               \r\n _______  _______  __   __  _______  __   __  __   __  _______         \r\n|       ||   _   ||  |_|  ||       ||  | |  ||  | |  ||  _    |        \r\n|    ___||  |_|  ||       ||    ___||  |_|  ||  | |  || |_|   |        \r\n|   | __ |       ||       ||   |___ |       ||  |_|  ||       |        \r\n|   ||  ||       ||       ||    ___||       ||       ||  _   |         \r\n|   |_| ||   _   || ||_|| ||   |___ |   _   ||       || |_|   |        \r\n|_______||__| |__||_|   |_||_______||__| |__||_______||_______|        ");

            Console.WriteLine("\n\n1 - JOGO DA VELHA");
            Console.WriteLine("2 - XADREZ");
            Console.Write("Selecione um dos jogos acima: ");

            string selecaoJogo = Console.ReadLine();
            while (selecaoJogo != "1" && selecaoJogo != "2")
            {
                Console.WriteLine(" _______  _______  __   __    __   __  ___   __    _  ______   _______ \r\n|  _    ||       ||  |_|  |  |  | |  ||   | |  |  | ||      | |       |\r\n| |_|   ||    ___||       |  |  |_|  ||   | |   |_| ||  _    ||   _   |\r\n|       ||   |___ |       |  |       ||   | |       || | |   ||  | |  |\r\n|  _   | |    ___||       |  |       ||   | |  _    || |_|   ||  |_|  |\r\n| |_|   ||   |___ | ||_|| |   |     | |   | | | |   ||       ||       |\r\n|_______||_______||_|   |_|    |___|  |___| |_|  |__||______| |_______|\r\n                       _______  _______                                \r\n                      |   _   ||       |                               \r\n                      |  |_|  ||   _   |                               \r\n                      |       ||  | |  |                               \r\n                      |       ||  |_|  |                               \r\n                      |   _   ||       |                               \r\n                      |__| |__||_______|                               \r\n _______  _______  __   __  _______  __   __  __   __  _______         \r\n|       ||   _   ||  |_|  ||       ||  | |  ||  | |  ||  _    |        \r\n|    ___||  |_|  ||       ||    ___||  |_|  ||  | |  || |_|   |        \r\n|   | __ |       ||       ||   |___ |       ||  |_|  ||       |        \r\n|   ||  ||       ||       ||    ___||       ||       ||  _   |         \r\n|   |_| ||   _   || ||_|| ||   |___ |   _   ||       || |_|   |        \r\n|_______||__| |__||_|   |_||_______||__| |__||_______||_______|        ");
                Console.WriteLine("\n Opção informada não existe");
            }
            string repetir = string.Empty;
            do
            {
                switch (selecaoJogo)
                {
                    case "1":
                        ImparPar.ExecutarJogoVelha();
                        ExecutarJogoDaVelha.Jogo();
                        break;
                    case "2":
                        ImparPar.ExecutarJogoXadrez();
                        Executar_Xadrez.ExecutarXadrez();
                        break;
                }
                Console.WriteLine("Deseja Jogar novamente? ");
                Console.WriteLine("1 - SIM");
                Console.WriteLine("2 - NÃO");
                Console.WriteLine("3 - SAIR PARA O MENU DE JOGOS");
                repetir = Console.ReadLine();
                while (repetir != "1" && repetir != "2" && repetir != "3")
                {
                    Console.WriteLine("Entrada informada não aceita, digite novamente uma das opções.");
                    Console.WriteLine("1 - SIM");
                    Console.WriteLine("2 - NÃO");
                    Console.WriteLine("3 - SAIR PARA O MENU DE JOGOS");
                    Console.Write("Deseja Jogar novamente? ");
                    repetir = Console.ReadLine();
                }
                if (repetir == "1")
                {
                    Console.Clear();
                    Array.Clear(ImparPar.Mat, 0, ImparPar.Mat.Length);
                    ImparPar.Contador = 0;
                }
                else if (repetir == "2")
                {
                    break;
                }
                else if (repetir == "3")
                {
                    Array.Clear(ImparPar.Mat, 0, ImparPar.Mat.Length);
                    ImparPar.Contador = 0;
                    Console.Clear();
                    Console.WriteLine(" _______  _______  __   __    __   __  ___   __    _  ______   _______ \r\n|  _    ||       ||  |_|  |  |  | |  ||   | |  |  | ||      | |       |\r\n| |_|   ||    ___||       |  |  |_|  ||   | |   |_| ||  _    ||   _   |\r\n|       ||   |___ |       |  |       ||   | |       || | |   ||  | |  |\r\n|  _   | |    ___||       |  |       ||   | |  _    || |_|   ||  |_|  |\r\n| |_|   ||   |___ | ||_|| |   |     | |   | | | |   ||       ||       |\r\n|_______||_______||_|   |_|    |___|  |___| |_|  |__||______| |_______|\r\n                       _______  _______                                \r\n                      |   _   ||       |                               \r\n                      |  |_|  ||   _   |                               \r\n                      |       ||  | |  |                               \r\n                      |       ||  |_|  |                               \r\n                      |   _   ||       |                               \r\n                      |__| |__||_______|                               \r\n _______  _______  __   __  _______  __   __  __   __  _______         \r\n|       ||   _   ||  |_|  ||       ||  | |  ||  | |  ||  _    |        \r\n|    ___||  |_|  ||       ||    ___||  |_|  ||  | |  || |_|   |        \r\n|   | __ |       ||       ||   |___ |       ||  |_|  ||       |        \r\n|   ||  ||       ||       ||    ___||       ||       ||  _   |         \r\n|   |_| ||   _   || ||_|| ||   |___ |   _   ||       || |_|   |        \r\n|_______||__| |__||_|   |_||_______||__| |__||_______||_______|        ");
                    Console.WriteLine("\n\n1 - JOGO DA VELHA");
                    Console.WriteLine("2 - XADREZ");
                    Console.Write("Selecione um dos jogos acima: ");
                    selecaoJogo = Console.ReadLine();
                }

            } while (repetir == "1" || repetir =="3");
        }

    }
}
