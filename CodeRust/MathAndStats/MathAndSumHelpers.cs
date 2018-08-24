using System;
using System.Collections.Generic;
using CodeRust.Helpers;

namespace CodeRust.MathAndStats
{
    public class MathAndStatsHelpers
    {
        public static void MathAndStatsProblems()
        {

            PrintHelpers.PrintArray("All Sum Combination", new[]{5}, AllSumsCombination.GetAllCombinations(5));

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
            Console.Write(IntegerDivision.IntegerDivisionRec(40, 4));

            var listInput = new List<int> { 4, 6, 8, 1, 3, 5, 10, 9, 7 };
            PrintHelpers.PrintArray("Pythagoras Triplet", listInput, PythagorasTriplet.GetPythagorasTriplets(listInput));

            Console.WriteLine("");
            Console.WriteLine("Find missing number");
            Console.WriteLine("Input: { 4, 6, 8, 1, 3, 5, 10, 9, 7} ");
            Console.WriteLine("Output: ");
            Console.Write(FindMissingNumber.Find_missing(listInput));

           
            var subsetInput = new List<int> { 2, 3, 4 };
            PrintHelpers.PrintArray("All Subsets", subsetInput, AllSubsets.Get_all_subsets(subsetInput));

            PrintHelpers.PrintArray("Permute String", new List<string>{"a", "b", "c"}, PermuteString.Permute_string("abc"));

            Console.WriteLine("");
            Console.WriteLine("Is Valid number");
            Console.WriteLine("Input: ++4456.054");
            Console.Write("Output: ");
            Console.Write(NumberValid.IsNumberValid("++4456.054"));

            Console.WriteLine("");
            Console.WriteLine("Power of Number");
            Console.WriteLine("Input: 3,2");
            Console.Write("Output: ");
            Console.Write(PowerOfNumber.Power(3,2));

            Console.WriteLine("");
            Console.WriteLine("Square root of Number");
            Console.WriteLine("Input: 2.2500");
            Console.Write("Output: ");
            Console.Write(SquareRootOfNumber.GetSquareRoot(2.2500));
        }
    }
}
