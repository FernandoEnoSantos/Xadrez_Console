namespace tabuleiro
{
    public class Peca
    {
        
        public Posicao posicao{get;set;}
        public Cor cor{get;protected set;}
        public int qtMovimentos{get;protected set;}//protected apenas alterada por ela mesma e subclasses
        public Tabuleiro tab{get;protected set;}



        public Peca(Posicao posicao, Tabuleiro tab, Cor cor){

            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qtMovimentos = 0;

        }




    }
}