using System;
using GameTop.Lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var marcos = new Jogador1("Marcos Silva");

            var jogador = new JogoFODA(marcos);
            jogador.InciarJogo();

            new JogoFODA(new Jogador2()).InciarJogo();        
        }
    }
}
