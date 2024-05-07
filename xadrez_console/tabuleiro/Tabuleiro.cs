namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        private Peca[,] Pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linha = linhas;
            Coluna = colunas;
            Pecas = new Peca[linhas, colunas];
        }

    }
}
