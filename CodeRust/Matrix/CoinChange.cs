using System;
namespace CodeRust.Matrix
{
    public class CoinChangeProblem
    {
        public static int CoinChange(int[] coins, int amount)
        {
            if(coins == null || coins.Length < 1 || amount == 0) {
                return -1;
            }

            int[] results = new int[amount+1];

            for (int i = 0; i < results.Length; i++) {
                results[i] = amount + 10;    
            }


            for (int i = 0; i < coins.Length; i++) {
                for (int j = 1; j <= amount; j ++) {
                    if(i <= j) {
                        int leftOver = j - coins[i];
                        if (leftOver == 0)
                        {
                            results[j] = 1;
                        }
                        else if (leftOver > 0){
                            results[j] = Math.Min(results[j], 1 + results[leftOver]);
                        }
                    }
                   
                }
            }

            return results[amount] > amount ? -1 : results[amount];
        }
    }
}
