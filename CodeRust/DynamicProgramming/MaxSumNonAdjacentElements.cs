using System;
namespace CodeRust.DynamicProgramming
{
    public class MaxSumNonAdjacentElements
    {
        //{1, 6, 10, 14, 50, -20, -5, -10}
        public static int FindMaxSum(int[] array) {
            if (array == null || array.Length < 1) { return -1; }

            int[] result = new int[array.Length];
            result[0] = array[0];
            if (array.Length == 1) { return result[0]; }
            result[1] = array[1];

            for (int i = 2; i < array.Length; i++) {
                var maxOfCurrentAndCurrentPlusPrevious = Math.Max(array[i] + result[i - 2], array[i]);
                result[i] = Math.Max(maxOfCurrentAndCurrentPlusPrevious, result[i - 1]);
            }
            return result[array.Length - 1];
        }
    }
}
