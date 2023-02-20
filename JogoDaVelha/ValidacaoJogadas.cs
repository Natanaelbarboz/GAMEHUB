using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JOGOSHUB.Jogadores;

namespace JOGOSHUB.JogoDaVelha
{
    class ValidacaoJogadas
    {
        public int Validacao()
        {
            int entrada = 0;


            if (ImparPar.Contador >= 5)
            {

                for (int i = 0; i < ImparPar.Mat.Length; i++)
                {

                    //PRIMEIRA LINHA
                    if (ImparPar.Mat[0, 0] != null && ImparPar.Mat[0, 1] != null && ImparPar.Mat[0, 2] != null)
                    {
                        if (ImparPar.Mat[0, 0] == ImparPar.Mat[0, 1] && ImparPar.Mat[0, 1] == ImparPar.Mat[0, 2])
                        {
                            entrada = 1;
                            break;

                        }

                    }
                    //SEGUNDA LINHA
                    if (ImparPar.Mat[1, 0] != null && ImparPar.Mat[1, 1] != null && ImparPar.Mat[1, 2] != null)
                    {
                        if (ImparPar.Mat[1, 0] == ImparPar.Mat[1, 1] && ImparPar.Mat[1, 1] == ImparPar.Mat[1, 2])
                        {
                            entrada = 1;
                        }

                    }
                    //TERCEIRA LINHA
                    if (ImparPar.Mat[2, 0] != null && ImparPar.Mat[2, 1] != null && ImparPar.Mat[2, 2] != null)
                    {
                        if (ImparPar.Mat[2, 0] == ImparPar.Mat[2, 1] && ImparPar.Mat[2, 1] == ImparPar.Mat[2, 2])
                        {
                            entrada = 1;
                        }
                    }
                    //PRIMEIRA COLUNA
                    if (ImparPar.Mat[0, 0] != null && ImparPar.Mat[1, 0] != null && ImparPar.Mat[2, 0] != null)
                    {
                        if (ImparPar.Mat[0, 0] == ImparPar.Mat[1, 0] && ImparPar.Mat[1, 0] == ImparPar.Mat[2, 0])
                        {
                            entrada = 1;
                            break;

                        }
                    }
                    // SEGUNDA COLUNA
                    if (ImparPar.Mat[0, 1] != null && ImparPar.Mat[1, 1] != null && ImparPar.Mat[2, 1] != null)
                    {
                        if (ImparPar.Mat[0, 1] == ImparPar.Mat[1, 1] && ImparPar.Mat[1, 1] == ImparPar.Mat[2, 1])
                        {
                            entrada = 1;
                            break;

                        }
                    }
                    // TERCEIRA COLUNA
                    if (ImparPar.Mat[0, 2] != null && ImparPar.Mat[1, 2] != null && ImparPar.Mat[2, 2] != null)
                    {
                        if (ImparPar.Mat[0, 2] == ImparPar.Mat[1, 2] && ImparPar.Mat[1, 2] == ImparPar.Mat[2, 2])
                        {
                            entrada = 1;
                            break;

                        }
                    }
                    //159
                    if (ImparPar.Mat[0, 0] != null && ImparPar.Mat[1, 1] != null && ImparPar.Mat[2, 2] != null)
                    {
                        if (ImparPar.Mat[0, 0] == ImparPar.Mat[1, 1] && ImparPar.Mat[1, 1] == ImparPar.Mat[2, 2])
                        {
                            entrada = 1;
                            break;

                        }
                    }
                    //
                    if (ImparPar.Mat[0, 2] != null && ImparPar.Mat[1, 1] != null && ImparPar.Mat[2, 0] != null)
                    {
                        if (ImparPar.Mat[0, 2] == ImparPar.Mat[1, 1] && ImparPar.Mat[1, 1] == ImparPar.Mat[2, 0])
                        {
                            entrada = 1;
                            break;

                        }
                    }
                    if (ImparPar.Contador > 9)
                    {
                        {
                            entrada = 3;
                            break;

                        }

                    }

                }

            }
            return entrada;

        }



    }
}
