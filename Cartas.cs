using System;
using System.Linq;
using System.Collections.Generic;

namespace Devops
{
    // Classe das cartas  
    public class Mao{
        private Carta[] _cartas {get;set;}
        private int _valor {get;set;}
        private IList<int> _valores;

        public Mao(Carta[] cartas){
            this._cartas = cartas;
            this._valores = new List<int>();
        }   
        //Regra
        //Carta Alta: A carta de maior valor. #10
        private void CartaMaiorValor(){
            int maiorValor = (int)_cartas.Max(x=>x.Valor);
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
    
    public class Carta 
    {
        public EnumValor Valor {get; set;}
        public EnumNaipe Naipe {get; set;}

    }

    public enum EnumValor
    {
        Dois, 
        Tres, 
        Quatro, 
        Cinco, 
        Seis, 
        Sete, 
        Oito, 
        Nove, 
        Dez, 
        Valete, 
        Dama, 
        Rei, 
        As
    }

    public enum EnumNaipe
    {  
        D,
        H,
        S,
        C
    }
    
}
