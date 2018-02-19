using System.Collections.Generic;
using System.Linq;

namespace CodeRust.Arrays
{
    public class MergeIntervals
    {   //https://www.geeksforgeeks.org/merging-intervals
        public static List<List<int>> Merge(List<List<int>> input)
        {
            input.OrderBy(ip => ip.First()).ThenBy(ip=>ip.Last());
            for (int i = 0; i < input.Count-1; i++)
            {
                if(input[i].First() <= input[i + 1].Last() && input[i].Last() >= input[i + 1].First())
                {
                    input[i + 1][0] = input[i].First();
                    input.RemoveAt(i);
                }
            }
            return input;
        }
    }
}
