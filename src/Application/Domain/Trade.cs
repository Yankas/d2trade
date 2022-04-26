using System.Text;

namespace Application.Domain;

public class Trade
{
    public decimal Price { get; }
    public string D2Item { get; }
    public bool Ethereal { get; }
    public int Sockets { get;  }

    public Trade(string name, int sockets ,bool ethereal = false, decimal price = 0.0m)
    {
        D2Item = name;
        Price = price;
        Sockets = sockets;
        Ethereal = ethereal;
    }
    
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"[{D2Item}]");
        if (Ethereal) sb.Append(" {Ethereal}");
        if (Sockets > 0) sb.Append($" {{{Sockets} Sockets}}");
        
        return sb.ToString();
    }
}
