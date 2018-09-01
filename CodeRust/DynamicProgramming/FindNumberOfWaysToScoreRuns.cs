using System;
namespace CodeRust.DynamicProgramming
{
    public class FindNumberOfWaysToScoreRuns
    {
        public static int ScoringOptions(int n, int[] scoringOptions)
        {
            if (n < 0) { return - 1; }
            if (n == 0) { return 0; }
            int[] result = new int[n + 1];
            result[0] = 1;
            for (int i = 1; i <= n; i++) {
                for (int j = 0; j< scoringOptions.Length; j++) {
                    int diff = i - scoringOptions[j];
                    if(diff >= 0) {
                        result[i] = result[i] + result[diff];
                    }
                }
            }
            return result[n];
        }
    }
}
