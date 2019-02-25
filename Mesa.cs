using System;

namespace Devops
{
   
    public class Mesa{
        public Mesa( Mao maoEsquerda, Mao maoDireita)
        {
            this._maoDireita = maoDireita;
            this._maoEsquerda = maoEsquerda;
        }

        private Mao _maoEsquerda;
        private Mao _maoDireita;

        //Regras
        //Carta Alta: A carta de maior valor. #10
        private void CartaMaiorValor(){
            
        }

        //Um Par: Duas cartas do mesmo valor. #20
        
        //Dois Pares: Dois pares diferentes. #30
        
        //Trinca: Três cartas do mesmo valor e das de valores diferentes. #40
        
        //Straight (sequência): Todas as cartas com valores consecutivos. #50
        
        //Flush: Todas as cartas do mesmo naipe. #60
        
        //Full House: Uma trinca e um par. #70
        
        //Quadra: Quatro cartas do mesmo valor. #80
        
        //Straight Flush: Todas as cartas são consecutivas e do mesmo naipe. #90
        
        //Royal Flush: A seqüência 10, Valete, Dama, Rei, Ás, do mesmo naipe. #100
    }    
    
   
}