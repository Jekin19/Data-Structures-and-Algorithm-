using System;
using System.Collections.Generic;

namespace CodeRust.Arrays
{
    //https://www.educative.io/collection/page/5642554087309312/5679846214598656/830001
    public class SumOfTwoValues
    {
        public static IEnumerable<IList<int>> GetPairs(int[] input, int sum)
        { 
            List<List<int>> results = new List<List<int>>();
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (set.Contains(sum - input[i]))
                {
                    results.Add(new List<int> { input[i], sum - input[i] });
                }
                set.Add(input[i]);
            }
            return results;
        }
    }
}
