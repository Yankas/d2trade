using Application.Domain.Enums;
using CommandDotNet;

namespace Presentation;

public class Commands
{
    
    [Command("add")]
    public void Add( [Option] decimal? price) => Console.WriteLine("a");

    [Command("rm")]
    public void Remove() => Console.WriteLine("b");
    
    [Command("db")]
    public void Query([Option('r', "rarity")] ItemRarity? rarity) => Console.WriteLine("c");
    
    [Command("ls")]
    public void List() => Console.WriteLine("c");
    
    [Command("export")] void Export() => Console.WriteLine("e");
}