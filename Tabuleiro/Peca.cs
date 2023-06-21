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

        public void decrementarQteMovimentos(){

            qtMovimentos--;

        }

        public bool existeMovimentosPossiveis(){
            bool[,] mat = movimentosPossiveis();

            for(int i = 0; i<tab.linhas; i++){
                for(int j = 0; j<tab.colunas; j++){

                    if(mat[i,j])// mesma coisa que mat[i,j] == true pois o IF verifica se é verdadeira a existencia dele
                    {
                        return true; // return corta o método


                    }
                }


            }
            return false;

        }

        public bool podeMoverPara(Posicao pos){
            return movimentosPossiveis()[pos.linha, pos.coluna];


        }


        public abstract bool[,] movimentosPossiveis();


    }
}