using tabuleiro;
using chess_console;
using xadrez;


try
{
    Tabuleiro tab = new Tabuleiro(8, 8);

    tab.ColocarPeca(new Torre(tab, tabuleiro.Enums.Cor.Preta), new Posicao(0, 0));
    tab.ColocarPeca(new Torre(tab, tabuleiro.Enums.Cor.Preta), new Posicao(1, 3));
    tab.ColocarPeca(new Rei(tab, tabuleiro.Enums.Cor.Preta), new Posicao(0, 0));



    Tela.ImprimirTabuleiro(tab);


}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}

