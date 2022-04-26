using System.Text;
using Application.Domain;

public class D2Item
{
    public string Name { get; }
    public string ItemRarity { get;  }
    public IEnumerable<RangeProperty> Properties { get; }
    public IEnumerable<StringProperty> StringProperties { get; }


}