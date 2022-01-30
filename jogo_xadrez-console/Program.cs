using System;
using tabuleiro;

namespace jogo_xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P = new Posicao(3, 4);

            Console.WriteLine($"Posicão: {P}");

            Console.ReadLine();
        }
    }
}
