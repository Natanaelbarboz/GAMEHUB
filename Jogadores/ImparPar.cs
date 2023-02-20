using JOGOSHUB.Xadrez.Tela;
using JOGOSHUB.JogoDaVelha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JOGOSHUB.Jogadores
{
    class ImparPar
    {

        public string NomePlay1 { get; set; }
        public string NomePlay2 { get; set; }
        public static string Impar { get; set; }
        public static string Par { get; set; }
        public static int Contador { get; set; }
        public static int ResultadoSorteio { get; set; }

        public static string[,]? Mat { get; set; }

        public static void ExecutarJogoVelha()
        {

            

            Console.WriteLine("\nATENÇÃO JOGADORES!!!");
            Console.WriteLine("\nSerá realizado um sorteio para ver quem começa a jogar primeiro.");

            Mat = new string[3, 3];

            ImparPar imparPar = new ImparPar();

            string opcaoP1;
            string opcaoP2;


            foreach (Jogadores play1 in Jogadores.Play1)
            {
                imparPar.NomePlay1 = play1.Nome;
            }

            foreach (Jogadores play2 in Jogadores.Play2)
            {
                imparPar.NomePlay2 = play2.Nome;
            }

            Console.Write($"\n{imparPar.NomePlay1} selcione Impar ou Par: ");
            opcaoP1 = Console.ReadLine().ToUpper();

            while (opcaoP1 != "IMPAR" && opcaoP1 != "PAR")
            {
                Console.WriteLine("\nOpção inválida.");
                Console.Write($"\n{imparPar.NomePlay1} selcione Impar ou Par: ");
                opcaoP1 = Console.ReadLine().ToUpper();

            }

            if (opcaoP1 == "IMPAR")
            {

                opcaoP2 = "Par";
                Console.WriteLine($"\n{imparPar.NomePlay2}, você ficou com Par");

                Impar = imparPar.NomePlay1;
                Par = imparPar.NomePlay2;
            }
            else
            {
                opcaoP1 = "Impar";
                Console.WriteLine($"\n{imparPar.NomePlay2}, você ficou com Impar");

                Impar = imparPar.NomePlay2;
                Par = imparPar.NomePlay1;

            }


            Console.WriteLine("\nAgora será feito o sorteio, precisone qualquer tecla Para continuar.\n");
            Console.ReadKey();
            Console.Clear();
            Random numeroAleatório = new Random();
            int aleatorio = numeroAleatório.Next(0, 9);

            if (aleatorio % 2 == 0)
            {
                Console.WriteLine("Resultado: Par");
                Console.WriteLine($"\n{Par}, você ficou com 'X' e começa");
                Console.WriteLine($"\n{Impar}, você ficou com 'O'");
                Console.WriteLine("Precione qualquer tecla para continuar");
                Console.ReadKey();
                ResultadoSorteio = 2;

            }
            else
            {
                Console.WriteLine("Resultado: Impar");
                Console.WriteLine($"\n{Impar}, você ficou com 'O' e começa");
                Console.WriteLine($"\n{Par}, você ficou com 'X'");
                Console.WriteLine("Precione qualquer tecla para continuar");
                Console.ReadKey();
                ResultadoSorteio = 1;

            }

        }

        public static void ExecutarJogoXadrez()
        {

            Console.WriteLine("\nATENÇÃO JOGADORES!!!");
            Console.WriteLine("\nSerá realizado um sorteio para ver quem começa a jogar primeiro.");


            ImparPar imparPar = new ImparPar();

            string opcaoP1;
            string opcaoP2;

            foreach (Jogadores play1 in Jogadores.Play1)
            {
                imparPar.NomePlay1 = play1.Nome;
            }

            foreach (Jogadores play2 in Jogadores.Play2)
            {
                imparPar.NomePlay2 = play2.Nome;
            }

            Console.Write($"\n{imparPar.NomePlay1} selcione Impar ou Par: ");
            opcaoP1 = Console.ReadLine().ToUpper();

            while (opcaoP1 != "IMPAR" && opcaoP1 != "PAR")
            {
                Console.WriteLine("\nOpção inválida.");
                Console.Write($"\n{imparPar.NomePlay1} selcione Impar ou Par: ");
                opcaoP1 = Console.ReadLine().ToUpper();

            }

            if (opcaoP1 == "IMPAR")
            {
                opcaoP2 = "Par";
                Console.WriteLine($"\n{imparPar.NomePlay2}, você ficou com Par");

                Impar = imparPar.NomePlay1;
                Par = imparPar.NomePlay2;
            }
            else
            {
                opcaoP1 = "Impar";
                Console.WriteLine($"\n{imparPar.NomePlay2}, você ficou com Impar");

                Impar = imparPar.NomePlay2;
                Par = imparPar.NomePlay1;
            }

            Console.WriteLine("\nAgora será feito o sorteio, precisone qualquer tecla Para continuar.\n");
            Console.ReadKey();
            Console.Clear();
            Random numeroAleatório = new Random();
            int aleatorio = numeroAleatório.Next(0, 9);

            if (aleatorio % 2 == 0)
            {
                Console.WriteLine("Resultado: Par");
                Console.WriteLine($"\n{Par}, você ficou com 'PAR' e começa");
                Console.WriteLine($"\n{Impar}, você ficou com 'IMPAR'");
                Console.WriteLine("Precione qualquer tecla para continuar");
                Console.ReadKey();
                ResultadoSorteio = 2;

            }
            else
            {
                Console.WriteLine("Resultado: Impar");
                Console.WriteLine($"\n{Impar}, você ficou com 'IMPAR' e começa");
                Console.WriteLine($"\n{Par}, você ficou com 'PAR'");
                Console.WriteLine("Precione qualquer tecla para continuar");
                Console.ReadKey();
                ResultadoSorteio = 1;

            }

            //
            //Executar_Xadrez.ExecutarXadrez();

        }



    }
}
