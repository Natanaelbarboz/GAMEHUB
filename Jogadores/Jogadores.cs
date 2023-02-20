using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using JOGOSHUB.JogoDaVelha;

namespace JOGOSHUB.Jogadores
{
    class Jogadores
    {

        public string Nome { get; set; }
        public string Senha { get; set; }
        public int Pontuacao { get; set; }
        public static List<Jogadores> Jogador { get; set; }
        public static List<Jogadores> Play1 { get; set; }
        public static List<Jogadores> Play2 { get; set; }
        public Jogadores() { }

        public Jogadores(string nome, string senha, int pontuacao)
        {
            Nome = nome;
            Senha = senha;
            Pontuacao = pontuacao;
        }

        public static void CadastroJogadorUm()
        {
            ManipulandoJson.DeserealizarJogador();
            Play1 = new();
            Console.Write("Informe o usuário que deseja cadastrar: ");
            string nome1 = Console.ReadLine();
            Console.Write("Informe a senha que deseja cadastrar: ");
            string senha1 = Console.ReadLine();
            int pontuacao1 = 0;

            foreach (Jogadores jogador1 in Jogador)
            {

                if (jogador1.Nome == nome1)
                {
                    Console.WriteLine("Não é possível cadastrar o nome informado, jogador já cadastrado no banco de dados");
                    Console.WriteLine("Diogite novamente:");
                    Console.Write("Informe o usuário que deseja cadastrar: ");
                    nome1 = Console.ReadLine();
                    Console.Write("Informe a senha que deseja cadastrar: ");
                    senha1 = Console.ReadLine();

                }
                else
                {
                    Jogadores.Jogador.Add(new Jogadores(nome1, senha1, pontuacao1));
                    Console.WriteLine("Jogador cadastrado com sucesso!");
                    Jogadores.Play1.Add(new Jogadores(nome1, senha1, pontuacao1));
                }

            }            

            ManipulandoJson.SerealizarJogador();
        }

        public static void SemRegistroJogadorUm()
        {
            Play1 = new();

            Console.Write("Informe o nome que deseja utilizar: ");
            string nome1 = Console.ReadLine();
            string senha1 = "Vazio";
            int pontuacao1 = 0;

            Jogadores.Play1.Add(new Jogadores(nome1, senha1, pontuacao1));
            Console.WriteLine("ATENÇÃO!!!");
            Console.WriteLine("As suas informações não ficaram salvas após o fim do jogo");

        }


        public static void CadastroJogadorDois()
        {
            Play2 = new();

            ManipulandoJson.DeserealizarJogador();

            Console.Write("Informe o usuário que deseja cadastrar: ");
            string nome2 = Console.ReadLine();
            Console.Write("Informe a senha que deseja cadastrar: ");
            string senha2 = Console.ReadLine();
            int pontuacao2 = 0;

            foreach (Jogadores jogador2 in Jogador)
            {

                if (jogador2.Nome == nome2)
                {
                    Console.WriteLine("Não é possível cadastrar o nome informado, jogador já cadastrado no banco de dados");
                    Console.WriteLine("Diogite novamente:");
                    Console.Write("Informe o usuário que deseja cadastrar: ");
                    nome2 = Console.ReadLine();
                    Console.Write("Informe a senha que deseja cadastrar: ");
                    senha2 = Console.ReadLine();

                }
                else
                {
                    Jogadores.Jogador.Add(new Jogadores(nome2, senha2, pontuacao2));
                    Console.WriteLine("Jogador cadastrado com sucesso!");
                    Jogadores.Play2.Add(new Jogadores(nome2, senha2, pontuacao2));
                }

            }
            /*
            Jogadores.Jogador.Add(new Jogadores(nome2, senha2, pontuacao2));
            Console.WriteLine("Jogador cadastrado com sucesso!");
            Jogadores.Play2.Add(new Jogadores(nome2, senha2, pontuacao2));
            */
            ManipulandoJson.SerealizarJogador();
        }
        public static void SemRegistroJogadorDois()
        {
            Play2 = new();

            Console.Write("Informe o nome que deseja utilizar: ");
            string nome2 = Console.ReadLine();
            string senha2 = "Vazio2";
            int pontuacao2 = 0;

            Jogadores.Play2.Add(new Jogadores(nome2, senha2, pontuacao2));
            Console.WriteLine("ATENÇÃO!!!");
            Console.WriteLine("As suas informações não ficaram salvas após o fim do jogo");

        }


        public static void JogadorUm()
        {
            Console.Write("Digite o seu usuário: ");
            string nome1 = Console.ReadLine();
            Console.Write("Informe a sua senha: ");
            string senha1 = Console.ReadLine();
            int pontuacao1 = 0;

            ManipulandoJson.DeserealizarJogador();
            Play1 = new();

            int contadorLoopForeach = 0;

            foreach (Jogadores jogador1 in Jogador)
            {
                contadorLoopForeach++;

                if (jogador1.Nome == nome1 && jogador1.Senha == senha1)
                {
                    Console.WriteLine($"Bem vindo: {jogador1.Nome}");
                    Console.WriteLine($"Sua pontuação atual é de {jogador1.Pontuacao} ponto(s)");
                    Jogadores.Play1.Add(new Jogadores(nome1, senha1, pontuacao1));
                    break;
                }

                int tentativaDeAcesso = 0;

                if (contadorLoopForeach == Jogador.Count)
                {
                    while (jogador1.Nome != nome1 || jogador1.Senha != senha1)
                    {
                        Console.WriteLine("\nUsuário ou senha incorreto");

                        Console.Write("Digite o seu usuário: ");
                        nome1 = Console.ReadLine();
                        Console.Write("Informe a sua senha: ");
                        senha1 = Console.ReadLine();

                        tentativaDeAcesso++;

                        if (jogador1.Nome == nome1 && jogador1.Senha == senha1)
                        {
                            contadorLoopForeach++;
                            Console.WriteLine($"Bem vindo: {jogador1.Nome}");
                            Console.WriteLine($"Sua pontuação atual é de {jogador1.Pontuacao} ponto(s)");
                            Jogadores.Play1.Add(new Jogadores(nome1, senha1, pontuacao1));
                            break;
                        }

                        if (tentativaDeAcesso >= 3)
                        {
                            Console.WriteLine("\nVocê excedeu o limite de tentativas");
                            break;
                        }
                    }
                }

                if (tentativaDeAcesso >= 3)
                {
                    Console.WriteLine("cadastre um usuário ou jogue sem cadastro");
                    Console.Write("Digite a opção desejada: 1 - CADASTRAR USUÁRIO | 2 - JOGAR SEM CADASTRO  ");
                    string entradaSwitch = Console.ReadLine();

                    while (entradaSwitch != "1" && entradaSwitch != "2")
                    {
                        Console.WriteLine("Entrada inválida, informe uma das opções abaixo");
                        Console.Write("Digite a opção desejada: 1 - CADASTRAR USUÁRIO | 2 - JOGAR SEM CADASTRO  ");
                        entradaSwitch = Console.ReadLine();
                    }

                    switch (entradaSwitch)
                    {
                        case "1":
                            CadastroJogadorUm();
                            break;
                        case "2":
                            SemRegistroJogadorUm();
                            break;

                    }

                }

            }
            ManipulandoJson.SerealizarJogador();
        }

        public static void JogadorDois()
        {
            string jogadorum = string.Empty;
            foreach (Jogadores jogador1 in Play1)
            {
                jogadorum = jogador1.Nome;
            }

            Console.Write("Digite o seu usuário: ");
            string nome2 = Console.ReadLine();
            Console.Write("Informe a sua senha: ");
            string senha2 = Console.ReadLine();
            int pontuacao2 = 0;

            ManipulandoJson.DeserealizarJogador();
            Play2 = new();

            int contadorLoopForeach = 0;

            foreach (Jogadores jogador2 in Jogador)
            {
                contadorLoopForeach++;

                if (jogador2.Nome == nome2 && jogador2.Senha == senha2 && jogadorum != jogador2.Nome)
                {
                    Console.WriteLine($"Bem vindo: {jogador2.Nome}");
                    Console.WriteLine($"Sua pontuação atual é de {jogador2.Pontuacao} ponto(s)");
                    Jogadores.Play2.Add(new Jogadores(nome2, senha2, pontuacao2));
                    break;
                }

                int tentativaDeAcesso = 0;

                if (contadorLoopForeach == Jogador.Count)
                {
                    while (jogador2.Nome != nome2 || jogador2.Senha != senha2 && jogadorum == jogador2.Nome)
                    {
                        Console.WriteLine("\nUsuário ou senha incorreto");
                        Console.Write("Digite o seu usuário: ");
                        nome2 = Console.ReadLine();
                        Console.Write("Informe a sua senha: ");
                        senha2 = Console.ReadLine();

                        tentativaDeAcesso++;

                        if (jogador2.Nome == nome2 && jogador2.Senha == senha2 && jogadorum != jogador2.Nome)
                        {
                            contadorLoopForeach++;
                            Console.WriteLine($"Bem vindo: {jogador2.Nome}");
                            Console.WriteLine($"Sua pontuação atual é de {jogador2.Pontuacao} ponto(s)");
                            Jogadores.Play2.Add(new Jogadores(nome2, senha2, pontuacao2));
                            break;
                        }

                        if (tentativaDeAcesso >= 3)
                        {
                            Console.WriteLine("\nVocê excedeu o limite de tentativas");
                            break;
                        }
                    }
                }

                if (tentativaDeAcesso >= 3)
                {
                    Console.WriteLine("cadastre um usuário ou jogue sem cadastro");
                    Console.Write("Digite a opção desejada: 1 - CADASTRAR USUÁRIO | 2 - JOGAR SEM CADASTRO  ");
                    string entradaSwitch = Console.ReadLine();

                    while (entradaSwitch != "1" && entradaSwitch != "2")
                    {
                        Console.WriteLine("Entrada inválida, informe uma das opções abaixo");
                        Console.Write("Digite a opção desejada: 1 - CADASTRAR USUÁRIO | 2 - JOGAR SEM CADASTRO  ");
                        entradaSwitch = Console.ReadLine();
                    }

                    switch (entradaSwitch)
                    {
                        case "1":
                            CadastroJogadorDois();
                            break;
                        case "2":
                            SemRegistroJogadorDois();
                            break;
                    }

                }

            }
            ManipulandoJson.SerealizarJogador();
        }

    }
}
