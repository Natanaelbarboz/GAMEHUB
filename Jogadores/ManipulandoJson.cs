using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JOGOSHUB.JogoDaVelha;

namespace JOGOSHUB.Jogadores
{
    class ManipulandoJson
    {

        public static void SerealizarJogador()
        {
            string file = @"..\..\..\Teste.json";
            //string file = "Teste.json";
            string jsonString = JsonSerializer.Serialize(Jogadores.Jogador);
            File.WriteAllText(file, jsonString);

        }      

        public static void DeserealizarJogador()
        {
            string file = @"..\..\..\Teste.json";
            //string file = "Teste.json";
            string jsonString = File.ReadAllText(file);
            Jogadores.Jogador = JsonSerializer.Deserialize<List<Jogadores>>(jsonString);

        }






    }
}
