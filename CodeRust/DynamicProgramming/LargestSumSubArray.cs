using System;
namespace CodeRust.DynamicProgramming
{
    public class LargestSumSubArray
    {
        public static int FindLargestSum(int [] array) {
            if (array == null || array.Length < 1) return -1;

            int currentSum = array[0];
            int maxSum = array[0];
            for (int i = 1; i < array.Length; i++) {
                if(currentSum + array[i] > 0) {
                    currentSum = Math.Max(currentSum + array[i], array[i]);
                } else {
                    currentSum = array[i];
                }
                maxSum = Math.Max(currentSum, maxSum);
            }
            return maxSum;
        }
    }
}
