using System;
using System.Collections.Generic;

namespace CodeRust.Arrays
{
    public class BuySellMaxProfit
    {
        public static IList<int> GetBuySellIndex(int[] input)
        {
            int buy = input[0];
            int cp = 0;
            int maxP = 0;
            List<int> result = new List<int>();
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] - buy > cp)
                {
                    cp = input[i] - buy;
                    if (maxP < cp)
                    {
                        maxP = cp;
                        result = new List<int> { buy, input[i] };
                    }
                }
                else if (input[i] < buy)
                {
                    buy = input[i];
                }
            }
            return result;
        }

        public static IEnumerable<IList<int>> GetAllBuySellIndex(int[] input)
        {
            int buy = input[0];
            int cp = 0;
            List<List<int>> result = new List<List<int>>();
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] - buy > cp)
                {
                    cp = input[i] - buy;
                }
                else
                {
                    if (cp > 0)
                    {
                        result.Add(new List<int> { buy, input[i-1] });
                        cp = 0;
                    }
                    buy = input[i];
                }
            }
            if (cp > 0)
            {
                result.Add(new List<int> { buy, input[input.Length-1] });
            }
            return result;
        }
    }
}
