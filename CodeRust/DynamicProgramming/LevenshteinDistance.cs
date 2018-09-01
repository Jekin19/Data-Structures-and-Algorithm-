using System;
namespace CodeRust.DynamicProgramming
{
    public class LevenshteinDistance
    {
        public static int GetLevenshteinDistance(string input1, string input2) {
            if (input1 == null && input2 == null) {
                return -1;
            }
            if(input1 == null) {
                return input2.Length;
            }
            if (input2 == null)
            {
                return input1.Length;
            }
            int max = 0;
            int[,] result = new int[input1.Length, input2.Length];
            for (int i = 0; i < input1.Length; i++) {
                for (int j = 0; j < input2.Length; j++)
                {
                    if(input1[i] == input2[j]) {
                        if(i == 0 || j == 0) {
                            result[i, j] = 1;
                        } else{
                            result[i, j] = result[i - 1, j - 1] + 1;
                        }
                    } else{
                        if(i != 0 && j!= 0 ) {
                            result[i, j] = Math.Max(result[i - 1, j], result[i, j - 1]);
                        } else if (i == 0 && j != 0) {
                            result[i, j] =  result[i, j - 1];
                        } else if (i != 0 && j == 0) {
                            result[i, j] =  result[i -1, j];
                        } 
                    }
                    max = Math.Max(max, result[i, j]);
                }
            }

            return Math.Max(input1.Length, input2.Length) - max;
        }
    }
}
