using System;
namespace CodeRust.DynamicProgramming
{
    public class CoinChangeProblem
    {
        public static int CoinChange(int amount, int[] denominations) {
            if(denominations == null || amount <= 0) {
                return -1;
            }
            int[] result = new int[amount + 1];
            result[0] = 1;
            foreach(var denomination in denominations) {
                for (int i = 1; i <= amount; i++) {
                    int diff = i - denomination;
                    if(diff >= 0) {
                        result[i] += result[diff];
                    }
                }
            }
            return result[amount];
        }
    }
}
