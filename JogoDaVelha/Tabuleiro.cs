using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JOGOSHUB.Jogadores;

namespace JOGOSHUB.JogoDaVelha
{
    class Tabuleiro
    {
        //public static string[,]? Mat { get; set; }

        public static void Tab()
        {
            string[,] mat = new string[3, 3];
            int mostrarLinha = 1;

            Console.WriteLine("\nMatriz de controle");

            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                Console.WriteLine(" ");
                for (int coluna = 0; coluna < mat.GetLongLength(1); coluna++)
                {
                    if (mat[linha, coluna] == null)
                    {
                        Console.Write($" {mostrarLinha} ");
                        mostrarLinha++;
                    }
                    else
                    {
                        Console.Write(mat[linha, coluna]);
                    }

                }
                Console.WriteLine("");
            }

        }

    }
}
