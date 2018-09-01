using System;
namespace CodeRust.DynamicProgramming
{
    public class DynamicProgrammingHelper
    {
        public static void DynamicProgrammingProblems(){

            //Fib
            Console.WriteLine("Fibonacci");
            var fibInput = 5;
            Console.WriteLine("Input: " + fibInput);
            var fibOutput = Fibonacci.GetFibonacci(fibInput);
            Console.WriteLine("Output: " + fibOutput);
            Console.WriteLine("");

            //Fib
            Console.WriteLine("Fibonacci 2");
            var fibInput2 = 0;
            Console.WriteLine("Input: " + fibInput2);
            var fibOutput2 = Fibonacci.GetFibonacci(fibInput2);
            Console.WriteLine("Output: " + fibOutput2);
            Console.WriteLine("");

            //Fib
            Console.WriteLine("Fibonacci 3");
            var fibInput3 = 1;
            Console.WriteLine("Input: " + fibInput3);
            var fibOutput3 = Fibonacci.GetFibonacci(fibInput3);
            Console.WriteLine("Output: " + fibOutput3);
            Console.WriteLine("");

            //Largest Sum Sub Array
            Console.WriteLine("Largest Sum Sub Array");
            var largestSumInput = new []{ 1, 10, -1, 11, 5, -30, -7, 20, 25, -35 };
            Console.WriteLine("Input: " + "{1, 10, -1, 11, 5, -30, -7, 20, 25, -35}");
            var largestSumOutput = LargestSumSubArray.FindLargestSum(largestSumInput);
            Console.WriteLine("Output: " + largestSumOutput);
            Console.WriteLine("");

            //Largest Sum Sub Array
            Console.WriteLine("Largest Sum Sub Array 2");
            var largestSumInput2 = new[] { -15, -14, -10, -19, -5, -21, -10 };
            Console.WriteLine("Input: " + "{-15, -14, -10, -19, -5, -21, -10}");
            var largestSumOutput2 = LargestSumSubArray.FindLargestSum(largestSumInput2);
            Console.WriteLine("Output: " + largestSumOutput2);
            Console.WriteLine("");

            //MaxSumNonAdjacentElements
            Console.WriteLine("Max Sum of Non-Adjacent Elements");
            var maxSumNonAdjacentInput = new[] { 1, 6, 10, 14, 50, -20, -5, -10 };
            Console.WriteLine("Input: " + "{1, 6, 10, 14, 50, -20, -5, -10}");
            var maxSumNonAdjacentOutput = MaxSumNonAdjacentElements.FindMaxSum(maxSumNonAdjacentInput);
            Console.WriteLine("Output: " + maxSumNonAdjacentOutput);
            Console.WriteLine("");


            //MaxSumNonAdjacentElements
            Console.WriteLine("Max Sum of Non-Adjacent Elements 2");
            var maxSumNonAdjacentInput2 = new[] { 1, -1, 6, 4, 2, -2 };
            Console.WriteLine("Input: " + "{ 1, -1, 6, 4, 2, -2 }");
            var maxSumNonAdjacentOutput2 = MaxSumNonAdjacentElements.FindMaxSum(maxSumNonAdjacentInput2);
            Console.WriteLine("Output: " + maxSumNonAdjacentOutput2);
            Console.WriteLine("");

            //FindNumberOfWaysToScoreRuns
            Console.WriteLine("Find Number Of Ways To ScoreRuns");
            var runsInput = 4;
            var scoringOptions = new []{1,2,4};
            Console.WriteLine("Input: " + runsInput + ";  scoringOptions: {1,2,4}");
            var runsOutput = FindNumberOfWaysToScoreRuns.ScoringOptions(runsInput, scoringOptions);
            Console.WriteLine("Output: " + runsOutput);
            Console.WriteLine("");


            //FindNumberOfWaysToScoreRuns
            Console.WriteLine("Find Number Of Ways To ScoreRuns");
            var runsInput2 = 5;
            var scoringOptions2 = new[] { 1, 2, 4 };
            Console.WriteLine("Input: " + runsInput2 + ";  scoringOptions: {1,2,4}");
            var runsOutput2 = FindNumberOfWaysToScoreRuns.ScoringOptions(runsInput2, scoringOptions2);
            Console.WriteLine("Output: " + runsOutput2);
            Console.WriteLine("");


            //Coin Change
            Console.WriteLine("Coin Change");
            var amountInput = 356;
            var coinOptions = new[] { 1, 5, 10 };
            Console.WriteLine("Input: " + amountInput + ";  coinOptions: {1, 5, 10}}");
            var coinCombOutput = CoinChangeProblem.CoinChange(amountInput, coinOptions);
            Console.WriteLine("Output: " + coinCombOutput);
            Console.WriteLine("");


            //Coin Change
            Console.WriteLine("Coin Change 2");
            var amountInput2 = 7;
            var coinOptions2 = new[] { 1, 2, 5 };
            Console.WriteLine("Input: " + amountInput2 + ";  coinOptions: {1, 2, 5 }");
            var coinCombOutput2 = CoinChangeProblem.CoinChange(amountInput2, coinOptions2);
            Console.WriteLine("Output: " + coinCombOutput2);
            Console.WriteLine("");


            //LevenshteinDistance
            Console.WriteLine("Levenshtein Distance");
            var lInput1 = "kitten";
            var lInput2 = "sitten";
            Console.WriteLine("Input1: " + lInput1 + ";  lInput2: " + lInput2);
            var lOutput = LevenshteinDistance.GetLevenshteinDistance(lInput1, lInput2);
            Console.WriteLine("Output: " + lOutput);
            Console.WriteLine("");

            //LevenshteinDistance
            Console.WriteLine("Levenshtein Distance2");
            var lInput21 = "aaple";
            var lInput22 = "akpke";
            Console.WriteLine("Input1: " + lInput21 + ";  lInput2: " + lInput22);
            var lOutput2 = LevenshteinDistance.GetLevenshteinDistance(lInput21, lInput22);
            Console.WriteLine("Output: " + lOutput2);
            Console.WriteLine("");
        }
    }
}
