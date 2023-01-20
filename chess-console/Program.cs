using tabuleiro;
using chess_console;
using xadrez;

Tabuleiro tab = new Tabuleiro(8, 8);

tab.ColocarPeca(new Torre(tab, tabuleiro.Enums.Cor.Preta), new Posicao(0, 0));
tab.ColocarPeca(new Torre(tab, tabuleiro.Enums.Cor.Preta), new Posicao(1, 3));
tab.ColocarPeca(new Rei(tab, tabuleiro.Enums.Cor.Preta), new Posicao(2, 4));



Tela.ImprimirTabuleiro(tab);

Console.ReadLine();



