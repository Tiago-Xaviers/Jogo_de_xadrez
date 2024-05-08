using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class Posicao
    {

        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public void definirValores(int linha, int coluna)
        {
            Coluna = coluna;
            Linha = linha;
        }


        public override string ToString()
        {
            return Linha
                + ","
                + Coluna;
        }
    }
}
