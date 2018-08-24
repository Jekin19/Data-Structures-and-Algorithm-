using System;
using System.Collections.Generic;
using CodeRust.Helpers;

namespace CodeRust.MathAndStats
{
    public class MathAndStatsHelpers
    {
        public static void MathAndStatsProblems()
        {

            //PrintHelpers.PrintArray("All Sum Combination", new[]{5}, AllSumsCombination.GetAllCombinations(5));

            Console.WriteLine("Kth Permutation Recusive");
            List<char> input = new List<char>{ '1', '2', '3', '4' };
            Console.WriteLine("Input: { '1', '2', '3', '4' } ");
            var sb = new System.Text.StringBuilder();
            KthPermutation.Find_kth_permutation_rec(input, 7, sb);
            Console.WriteLine("Output: " + sb);

            Console.WriteLine("");

            Console.WriteLine("Kth Permutation");
            input = new List<char> { '1', '2', '3', '4' };
            Console.WriteLine("Input: { '1', '2', '3', '4' } ");
            sb = new System.Text.StringBuilder();
            KthPermutation.Find_kth_permutation_rec(input, 7, sb);
            Console.WriteLine("Output: " + sb);

            Console.WriteLine("");
            Console.WriteLine("Integer Division");
            Console.WriteLine("Input: ");
            Console.WriteLine("Dividen: 40; Divisor: 4 ");
            Console.WriteLine("Output: ");
            Console.WriteLine(IntegerDivision.IntegerDivisionRec(40, 4));

            var listInput = new List<int> { 4, 6, 8, 1, 3, 5, 10 };
            PrintHelpers.PrintArray("Pythagoras Triplet", listInput, PythagorasTriplet.GetPythagorasTriplets(listInput));
        }
    }
}
