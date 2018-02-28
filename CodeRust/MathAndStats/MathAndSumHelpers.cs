using System;
using CodeRust.Helpers;

namespace CodeRust.MathAndStats
{
    public class MathAndStatsHelpers
    {
        public static void MathAndStatsProblems()
        {
           
            PrintHelpers.PrintArray("All Sum Combination", new[]{5}, AllSumsCombination.GetAllCombinations(5));
        }
    }
}
