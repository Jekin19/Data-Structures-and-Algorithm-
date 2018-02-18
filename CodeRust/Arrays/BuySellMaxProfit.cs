using System;
using System.Collections.Generic;

namespace CodeRust.Arrays
{
    public class BuySellMaxProfit
    {
        public static IEnumerable<IList<int>> GetBuySellIndex(int[] input)
        {
            List<List<int>> results = new List<List<int>>();
            int max = 0;
            int min = 0;
            for (int i = 0; i < input.Length-1; i++)
            {
                
                if(input[i] < input[i+1])
                {
                    if(input[i+1] < input[max])
                    {
                        results.Add(new List<int>{min, max});
                    }
                    else
                    {
                        max = i + 1;
                        if(max == input.Length-1)
                        {
                            results.Add(new List<int> { min, max });
                        }
                    }
                }
                else
                {
                    results.Add(new List<int> { min, max });
                    min = max = i + 1;
                }
            }


            return results;
        }
    }
}
