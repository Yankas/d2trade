using System.Diagnostics.Contracts;
using Quickenshtein;

namespace Application.Application;

public class StringMatcher
{
    [Pure]
    public int ClosestMatch(string source, IEnumerable<string> targetList)
    {
        return targetList.Select(x => Levenshtein.GetDistance(source, x)).Min();
    }

}