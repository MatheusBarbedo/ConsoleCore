using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador1 : iJogador
   {
        public readonly string _Nome;
        public Jogador1(string Nome) => _Nome = Nome;
        public string Chuta() => $"{_Nome} esta chutando \n";

        public string Corre() => $"{_Nome} esta correndo \n";

        public string Passe() => $"{_Nome} esta passando \n";
    }
}