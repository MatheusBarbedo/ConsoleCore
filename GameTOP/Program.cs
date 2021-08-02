using System;
using GameTOP.lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new Jogo(
                new Jogador1("Ronaldo"),
                new Jogador2("Maradona"),
                new Jogador3("Messi")
            );
            jogo.IniciarJogo();
        }
    }
}