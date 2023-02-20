using JOGOSHUB.Jogadores;
using JOGOSHUB.JogoDaVelha;
using JOGOSHUB.Xadrez.Tela;
using System.Linq;

namespace JOGOSHUB.Ranking
{
    class RankingJogadores
    {
        // CÓDIGO NÃO FINALIZADO!!!
        public static void VerJogadores()
        {
            ManipulandoJson.DeserealizarJogador();
           
            List<Jogadores.Jogadores> listaJogadores = new();            

            foreach (Jogadores.Jogadores lista in Jogadores.Jogadores.Jogador)
            {
                listaJogadores.Add(new(lista.Nome, lista.Senha, lista.Pontuacao));                
            }

            var ordernar = listaJogadores.OrderByDescending(a => a.Pontuacao).ThenByDescending(a => a.Pontuacao);
            Console.WriteLine("Ranking de Jogadores");
            int colocacao = 0;

            foreach (var lista in ordernar)
            {
                colocacao++;
                Console.WriteLine($"{colocacao}° - Nome: {lista.Nome}, Pontuação: {lista.Pontuacao}");                
            }            

        }

    }
}
