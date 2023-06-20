using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    
    public class Tela{


        public static void imprimirTabuleiro(Tabuleiro tab){

            for(int i = 0; i < tab.linhas ; i++){
                System.Console.Write(8-i+ " ");

                for(int j = 0; j < tab.colunas;j++){
                                           
                    imprimirPeca(tab.peca(i,j));
                                        
                }               

                System.Console.WriteLine();  


            }
            System.Console.WriteLine("  a b c d e f g h");


        }

                public static void imprimirTabuleiro(Tabuleiro tab,bool[,] posicoesPossiveis){

                    ConsoleColor fundoOriginal = Console.BackgroundColor;
                    ConsoleColor fundoAlterado = ConsoleColor.DarkGray;


                            for(int i = 0; i < tab.linhas ; i++){
                                System.Console.Write(8-i+ " ");

                                for(int j = 0; j < tab.colunas;j++){
                                                        

                                    if(posicoesPossiveis[i,j] == true){   

                                        Console.BackgroundColor = fundoAlterado;

                                    } 
                                    else{
                                        Console.BackgroundColor = fundoOriginal;
                                    }              

                                    imprimirPeca(tab.peca(i,j));
                                    Console.BackgroundColor = fundoOriginal;

                                }               

                                System.Console.WriteLine();  


                            }
                            System.Console.WriteLine("  a b c d e f g h");
                            Console.BackgroundColor = fundoOriginal;


        }



        public static PosicaoXadrez lerPosicaoXadrez(){

            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1]+"");// essa concatenação do vet s com string vazio, força a informação a ser string

            return new PosicaoXadrez(coluna,linha);


        }

        public static void imprimirPeca(Peca peca){

            if(peca == null){

                System.Console.Write("- ");

            }
            else{
                        if(peca.cor == Cor.Branca){

                            System.Console.Write(peca);


                        }
                        else{
                            ConsoleColor aux = Console.ForegroundColor;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.Write(peca);
                            Console.ForegroundColor = aux;
                            // macete para mudar a cor do console para amarelo, armazenar a cor original em auxiliar
                            // imprimir amarelo e depois voltar a cor original

                        }

                System.Console.Write(" ");        

            }

        }


    }


}

