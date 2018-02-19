using System.Collections.Generic;
using System.Linq;

namespace CodeRust.Arrays
{
    public class MergeIntervals
    {
        public static List<List<int>> Merge(List<List<int>> input)
        {
            List<List<int>> results = new List<List<int>>();
            input.OrderBy(ip => ip.First()).ThenBy(ip=>ip.Last());
            for (int i = 0; i < input.Count-1; i++)
            {
                var firstFirst = input[i].First();
                var firstLast = input[i].Last();
                var secondFirst = input[i+1].First();
                var secondLast = input[i+1].Last();
                if(firstFirst <= secondLast && firstLast >= secondFirst)
                {
                    //results.Add(new List<int>{input[i].First(), input[i+1].Last()});
                    input[i + 1][0] = input[i].First();
                    input.RemoveAt(i);
                }
            }
            return input;
        }
    }
}
