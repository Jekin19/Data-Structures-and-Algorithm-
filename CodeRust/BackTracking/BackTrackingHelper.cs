using System;

namespace CodeRust.BackTracking
{
    public class BackTrackingHelper
    {
		public static void BackTrackingProblems(){


            Console.WriteLine("Parenthesis");
            var pInput = 4;
            Console.WriteLine("Input: " + pInput);
            var pOutput = Parenthesis.GetParenthesis(pInput);
            Console.WriteLine("Output: " + pOutput);
            Console.WriteLine("");
        }
    }
}
