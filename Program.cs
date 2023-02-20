using System;
using JOGOSHUB.Jogadores;
using JOGOSHUB.Ranking;
using JOGOSHUB.Xadrez.Tela;

namespace JOGOSHUB;


class Program
{
    public static void Main(string[] args)
    {

        string entrdaMenuInicial = string.Empty;

        do
        {
            Console.WriteLine(" _______  _______  __   __    __   __  ___   __    _  ______   _______ \r\n|  _    ||       ||  |_|  |  |  | |  ||   | |  |  | ||      | |       |\r\n| |_|   ||    ___||       |  |  |_|  ||   | |   |_| ||  _    ||   _   |\r\n|       ||   |___ |       |  |       ||   | |       || | |   ||  | |  |\r\n|  _   | |    ___||       |  |       ||   | |  _    || |_|   ||  |_|  |\r\n| |_|   ||   |___ | ||_|| |   |     | |   | | | |   ||       ||       |\r\n|_______||_______||_|   |_|    |___|  |___| |_|  |__||______| |_______|\r\n                       _______  _______                                \r\n                      |   _   ||       |                               \r\n                      |  |_|  ||   _   |                               \r\n                      |       ||  | |  |                               \r\n                      |       ||  |_|  |                               \r\n                      |   _   ||       |                               \r\n                      |__| |__||_______|                               \r\n _______  _______  __   __  _______  __   __  __   __  _______         \r\n|       ||   _   ||  |_|  ||       ||  | |  ||  | |  ||  _    |        \r\n|    ___||  |_|  ||       ||    ___||  |_|  ||  | |  || |_|   |        \r\n|   | __ |       ||       ||   |___ |       ||  |_|  ||       |        \r\n|   ||  ||       ||       ||    ___||       ||       ||  _   |         \r\n|   |_| ||   _   || ||_|| ||   |___ |   _   ||       || |_|   |        \r\n|_______||__| |__||_|   |_||_______||__| |__||_______||_______|        ");
            Console.WriteLine("\n\n\n1 - ENTRAR NO GAMEHUB");
            Console.WriteLine("2 - RANKING DE JOGADORES");
            Console.WriteLine("3 - VER CRÉDITOS");
            Console.WriteLine("4 - ENCERRAR PROGRAMA");
            Console.Write("Informe a opção desejada: ");
            entrdaMenuInicial = Console.ReadLine();

            while (entrdaMenuInicial != "1" && entrdaMenuInicial != "2" && entrdaMenuInicial != "3" && entrdaMenuInicial != "4")
            {
                Console.Clear();
                Console.WriteLine("A opção informada não existe, gentileza selecione uma das opções abaixo");
                Console.WriteLine("\n\n\n1 - ENTRAR NO GAMEHUB");
                Console.WriteLine("2 - RANKING DE JOGADORES");
                Console.WriteLine("3 - VER CRÉDITOS");
                Console.WriteLine("4 - ENCERRAR PROGRAMA");
                Console.Write("Informe a opção desejada: ");
                entrdaMenuInicial = Console.ReadLine();

            }

            switch (entrdaMenuInicial)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine(" _______  _______  __   __    __   __  ___   __    _  ______   _______ \r\n|  _    ||       ||  |_|  |  |  | |  ||   | |  |  | ||      | |       |\r\n| |_|   ||    ___||       |  |  |_|  ||   | |   |_| ||  _    ||   _   |\r\n|       ||   |___ |       |  |       ||   | |       || | |   ||  | |  |\r\n|  _   | |    ___||       |  |       ||   | |  _    || |_|   ||  |_|  |\r\n| |_|   ||   |___ | ||_|| |   |     | |   | | | |   ||       ||       |\r\n|_______||_______||_|   |_|    |___|  |___| |_|  |__||______| |_______|\r\n                       _______  _______                                \r\n                      |   _   ||       |                               \r\n                      |  |_|  ||   _   |                               \r\n                      |       ||  | |  |                               \r\n                      |       ||  |_|  |                               \r\n                      |   _   ||       |                               \r\n                      |__| |__||_______|                               \r\n _______  _______  __   __  _______  __   __  __   __  _______         \r\n|       ||   _   ||  |_|  ||       ||  | |  ||  | |  ||  _    |        \r\n|    ___||  |_|  ||       ||    ___||  |_|  ||  | |  || |_|   |        \r\n|   | __ |       ||       ||   |___ |       ||  |_|  ||       |        \r\n|   ||  ||       ||       ||    ___||       ||       ||  _   |         \r\n|   |_| ||   _   || ||_|| ||   |___ |   _   ||       || |_|   |        \r\n|_______||__| |__||_|   |_||_______||__| |__||_______||_______|        ");
                    Menu.MenuJogos();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine(" _______  _______  __   __    __   __  ___   __    _  ______   _______ \r\n|  _    ||       ||  |_|  |  |  | |  ||   | |  |  | ||      | |       |\r\n| |_|   ||    ___||       |  |  |_|  ||   | |   |_| ||  _    ||   _   |\r\n|       ||   |___ |       |  |       ||   | |       || | |   ||  | |  |\r\n|  _   | |    ___||       |  |       ||   | |  _    || |_|   ||  |_|  |\r\n| |_|   ||   |___ | ||_|| |   |     | |   | | | |   ||       ||       |\r\n|_______||_______||_|   |_|    |___|  |___| |_|  |__||______| |_______|\r\n                       _______  _______                                \r\n                      |   _   ||       |                               \r\n                      |  |_|  ||   _   |                               \r\n                      |       ||  | |  |                               \r\n                      |       ||  |_|  |                               \r\n                      |   _   ||       |                               \r\n                      |__| |__||_______|                               \r\n _______  _______  __   __  _______  __   __  __   __  _______         \r\n|       ||   _   ||  |_|  ||       ||  | |  ||  | |  ||  _    |        \r\n|    ___||  |_|  ||       ||    ___||  |_|  ||  | |  || |_|   |        \r\n|   | __ |       ||       ||   |___ |       ||  |_|  ||       |        \r\n|   ||  ||       ||       ||    ___||       ||       ||  _   |         \r\n|   |_| ||   _   || ||_|| ||   |___ |   _   ||       || |_|   |        \r\n|_______||__| |__||_|   |_||_______||__| |__||_______||_______|        ");
                    Console.WriteLine("\n\n");
                    RankingJogadores.VerJogadores();
                    Console.Write("Prescione qualquer tecla para continuar");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine(" _______  _______  __   __    __   __  ___   __    _  ______   _______ \r\n|  _    ||       ||  |_|  |  |  | |  ||   | |  |  | ||      | |       |\r\n| |_|   ||    ___||       |  |  |_|  ||   | |   |_| ||  _    ||   _   |\r\n|       ||   |___ |       |  |       ||   | |       || | |   ||  | |  |\r\n|  _   | |    ___||       |  |       ||   | |  _    || |_|   ||  |_|  |\r\n| |_|   ||   |___ | ||_|| |   |     | |   | | | |   ||       ||       |\r\n|_______||_______||_|   |_|    |___|  |___| |_|  |__||______| |_______|\r\n                       _______  _______                                \r\n                      |   _   ||       |                               \r\n                      |  |_|  ||   _   |                               \r\n                      |       ||  | |  |                               \r\n                      |       ||  |_|  |                               \r\n                      |   _   ||       |                               \r\n                      |__| |__||_______|                               \r\n _______  _______  __   __  _______  __   __  __   __  _______         \r\n|       ||   _   ||  |_|  ||       ||  | |  ||  | |  ||  _    |        \r\n|    ___||  |_|  ||       ||    ___||  |_|  ||  | |  || |_|   |        \r\n|   | __ |       ||       ||   |___ |       ||  |_|  ||       |        \r\n|   ||  ||       ||       ||    ___||       ||       ||  _   |         \r\n|   |_| ||   _   || ||_|| ||   |___ |   _   ||       || |_|   |        \r\n|_______||__| |__||_|   |_||_______||__| |__||_______||_______|        ");
                    Creditos.Criador();
                    break;
                    case "4":
                    Console.WriteLine(" _______  _______  __   __    __   __  ___   __    _  ______   _______ \r\n|  _    ||       ||  |_|  |  |  | |  ||   | |  |  | ||      | |       |\r\n| |_|   ||    ___||       |  |  |_|  ||   | |   |_| ||  _    ||   _   |\r\n|       ||   |___ |       |  |       ||   | |       || | |   ||  | |  |\r\n|  _   | |    ___||       |  |       ||   | |  _    || |_|   ||  |_|  |\r\n| |_|   ||   |___ | ||_|| |   |     | |   | | | |   ||       ||       |\r\n|_______||_______||_|   |_|    |___|  |___| |_|  |__||______| |_______|\r\n                       _______  _______                                \r\n                      |   _   ||       |                               \r\n                      |  |_|  ||   _   |                               \r\n                      |       ||  | |  |                               \r\n                      |       ||  |_|  |                               \r\n                      |   _   ||       |                               \r\n                      |__| |__||_______|                               \r\n _______  _______  __   __  _______  __   __  __   __  _______         \r\n|       ||   _   ||  |_|  ||       ||  | |  ||  | |  ||  _    |        \r\n|    ___||  |_|  ||       ||    ___||  |_|  ||  | |  || |_|   |        \r\n|   | __ |       ||       ||   |___ |       ||  |_|  ||       |        \r\n|   ||  ||       ||       ||    ___||       ||       ||  _   |         \r\n|   |_| ||   _   || ||_|| ||   |___ |   _   ||       || |_|   |        \r\n|_______||__| |__||_|   |_||_______||__| |__||_______||_______|        ");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("OBRIGADO POR ACESSAR O GAMEHUB");
                    Console.WriteLine("VOLTE SEMPRE!!");
                    break;


            }

        } while (entrdaMenuInicial != "4");







    }


}
