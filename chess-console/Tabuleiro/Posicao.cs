using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chess_console;


namespace tabuleiro
{
    internal class Posicao
    {
        public double Linha { get; set; }
        public double Coluna { get; set; }

        public Posicao(double linha, double coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
        }

        public override string ToString()
        {
            return $"{Linha}, {Coluna}";
        }
    }
}
