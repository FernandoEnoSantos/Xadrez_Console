namespace tabuleiro
{
    public class Tabuleiro
    {

        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas; //matriz de peças não pode ser acessados por alguma classe de fora


        
        public Tabuleiro(int linhas, int colunas){

        this.linhas = linhas;
        this.colunas = colunas;
        pecas = new Peca[linhas,colunas];



        }   



    }
}