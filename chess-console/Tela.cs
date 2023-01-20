using tabuleiro;

namespace chess_console
{
    internal class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i += 1)
            {
                for (int j = 0; j < tab.Colunas; j += 1)
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
