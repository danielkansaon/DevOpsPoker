using System.Collections.Generic;
using System.Linq;

public class Regras
{
    #region Regras
    //Carta Alta: A carta de maior valor. #10
    public Carta CartaAlta(List<Carta> cartasMao)
    {
        return cartasMao.FirstOrDefault(c => c.Valor == cartasMao.Max(v => v.Valor));
    }

    //Um Par: Duas cartas do mesmo valor. #20
    public int UmPar(List<Carta> cartasMao)
    {
        return 0;
    }

    //Dois Pares: Dois pares diferentes. #30
    public int DoisPares(List<Carta> cartasMao)
    {
        return 0;
    }

    //Trinca: Três cartas do mesmo valor e das de valores diferentes. #40
    public int Trinca(List<Carta> cartasMao)
    {
        foreach(var carta in cartasMao)
        {
            var qtndMesmoValor = cartasMao.Select(c => c.Valor = carta.Valor).ToList().Count();
            if(qtndMesmoValor > 3)
            {
                return 40;   
            }
        }
        
        return 0;
    }

    //Straight (sequência): Todas as cartas com valores consecutivos. #50
    public int Straight(List<Carta> cartasMao)
    {
        return 0;
    }

    //Flush: Todas as cartas do mesmo naipe. #60
    public int Flush()
    {
        return 60;
    }

    //Full House: Uma trinca e um par. #70
    public int FullHouse(List<Carta> cartasMao)
    {
        return 0;
    }

    //Quadra: Quatro cartas do mesmo valor. #80
    public int Quadra(List<Carta> cartasMao)
    {
        return 0;s
    }

    //Straight Flush: Todas as cartas são consecutivas e do mesmo naipe. #90
    public int StraightFlush()
    {
        return 90;
    }

    //Royal Flush: A seqüência 10, Valete, Dama, Rei, Ás, do mesmo naipe. #100
    public int RoyalFlush()
    {
        return 100;
    }

    public int CalcularPontosMao(List<Carta> cartasMao)
    {
        if(ValidaTodosNaipesIguas(cartasMao))
        {
            if(ValidaSequenciaDezAAs(cartasMao))
            {
                RoyalFlush();
            }
            else if(ValidaSequenciaNumerica(cartasMao))
            {
                StraightFlush();
            }
            else
            {
                Flush();
            }
        }
        else
        {

        }
    }

    #endregion 

    #region Metodos Complementares

    public bool ValidaTodosNaipesIguas(List<Carta> cartasMao)
    {
        var naipeMao = cartasMao.FirstOrDefault().Naipe;
        foreach (var carta in cartasMao)
        {
            if (!carta.Naipe.Equals(naipeMao))
            {
                return false;
            }
        }
        return true;
    }

    public bool ValidaSequenciaNumerica(List<Carta> cartasMao)
    {
        var sequenciaMao = cartasMao.Select(c => c.Valor.CartaValor).ToList();
        var sequenciaBase = new Valor().CartaValor.Where(c => c.Value >= sequenciaMao[0].Values.FirstOrDefault());

        foreach(var sequencia in sequenciaBase)
        {
            if(!sequenciaMao.Exists(c => c.Values.ToString().Equals(sequencia.Value.ToString())))
            {
                return false;
            }
            return true;
        }

        return true;
    }

    public bool ValidaSequenciaDezAAs(List<Carta> cartasMao)
    {
        var sequenciaBase = new Valor().CartaValor.TakeLast(5);
        var sequenciaMao = cartasMao.Select(c => c.Valor.CartaValor).ToList();
        
        foreach(var sequencia in sequenciaBase)
        {
            if(!sequenciaMao.Exists(c => c.Values.ToString().Equals(sequencia.Value.ToString())))
            {
                return false;
            }
            return true;
        }
        return true;
    }

    /* public int CartasMesmoValor(List<Carta> cartasMao)
    {
        KeyValuePair<int, int> valoresRepeticao = new KeyValuePair<int, int>();
        foreach(var carta in cartasMao)
        {
            if()
        }

    }*/

    #endregion
}
