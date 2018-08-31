using System;
using System.Collections.Generic;

namespace CodeRust.MathAndStats
{
    public class PermuteString
    {
        public static List<String> Permute_string(String input)
        {
            List<string> result = new List<string>();
            if (string.IsNullOrEmpty(input)) {
                return result;
            }
            PermuteStringRec(input, result, 0, input.Length - 1);
            return result;
        }

        private static void PermuteStringRec(string input, List<string> result, int currentIndex, int endIndex) {
            if (input == null) { return; }
            if(currentIndex == endIndex) {
                result.Add(input);
                return;
            }
            for (int i = currentIndex; i <= endIndex; i++)
            {
                input = Swap(input, currentIndex, i);
                PermuteStringRec(input, result, currentIndex + 1, endIndex);
                input = Swap(input, currentIndex, i);
            }
        }

        private static string Swap(string input, int start, int end) {
            char[] inputArray = input.ToCharArray();
            char temp = inputArray[start];
            inputArray[start] = inputArray[end];
            inputArray[end] = temp;
            return new string(inputArray);
        }
    }

}
