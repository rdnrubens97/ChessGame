﻿using tabuleiro;
using chess_console;
using xadrez;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while (!partida.Terminada)
    {
        try
        {
            Console.Clear();
            Tela.ImprimirPartida(partida);
            Console.WriteLine();
            Console.Write("Origem: ");
            Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
            partida.ValidarPosicaoDeOrigem(origem);

            bool[,] PosicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();

            Console.Clear();
            Tela.ImprimirTabuleiro(partida.Tab, PosicoesPossiveis);

            Console.WriteLine();
            Console.Write("Destino: ");
            Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
            partida.ValidarPosicaoDestino(origem, destino);

            partida.RealizaJogada(origem, destino);
        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
            Console.Write("Aperte qualquer tecla para continuar: ");
            Console.ReadLine();
        }
    }

}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}

Console.Write("Aperte qualquer tecla para continuar: ");
Console.ReadLine();

