using System;
using System.Collections.Generic;

namespace CodeRust.Arrays
{
    public class SumOfThreeValues
    {
        public static List<List<int>> SumOfThreeValue(int[] input, int k){
            List<List<int>> result = new List<List<int>>();
            if(input == null || input.Length < 2) {
                return null;
            }

            Array.Sort(input);
            for (int i = 2; i< input.Length; i++) {
                int start = 0;
                int end = i - 1;
                while(start < end) {
                    if(input[start] + input[end] + input[i] == k ) {
                        result.Add(new List<int> { input[start], input[end], input[i] });
                        start++;
                        end--;
                    } 
                    else if(input[start] + input[end] + input[i] < k) {
                        start++;
                    } else {
                        end--;
                    }
                }
            }
            return result;
        }
    }
}
