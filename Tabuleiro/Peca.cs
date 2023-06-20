namespace tabuleiro
{
   public abstract class Peca
    {
        
        public Posicao posicao{get;set;}
        public Cor cor{get;protected set;}
        public int qtMovimentos{get;protected set;}//protected apenas alterada por ela mesma e subclasses
        public Tabuleiro tab{get;protected set;}



        public Peca( Tabuleiro tab, Cor cor){

            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qtMovimentos = 0;

        }
        public void incrementarQteMovimentos(){

            qtMovimentos++;

        }

        public abstract bool[,] movimentosPossiveis();


    }
}