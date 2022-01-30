﻿using tabuleiro;
using System;
namespace jogo_xadrez_console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for(int i=0; i < tab.Linhas; i++)
            {
                for(int j=0; j < tab.Colunas; j++)
                {
                    if (tab.Peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write($"{tab.Peca(i, j)} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
