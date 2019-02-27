using System.Collections.Generic;

public class Mao
{
    private List<Carta> cartasMao { get; set; }
    private int pontosMao { get; set; }

    public int ContarPontosMao(List<Carta> cartasMao)
    {
        return pontosMao;
    }
}

public class Carta
{
    public Valor Valor { get; set; }
    public Naipe Naipe { get; set; }
}

public enum Naipe
{  
    Paus,
    Ouros,
    Espadas,
    Copas
}

public class Valor
{
    private Dictionary<string, int> cartaValor = new Dictionary<string, int>()
    {
        {"dois", 2},
        {"tres", 3},
        {"quatro", 4},
        {"cinco", 5},
        {"seis", 6},
        {"sete", 7},
        {"oito", 8},
        {"nove", 9},
        {"dez", 10},
        {"valete", 11},
        {"dama", 12},
        {"rei", 13},
        {"as", 14}
    };

    public Dictionary<string, int> CartaValor 
    {
        get 
        {
            return cartaValor;
        }
    }
}