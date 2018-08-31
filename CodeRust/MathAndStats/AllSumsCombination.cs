using System.Collections.Generic;

namespace CodeRust.MathAndStats
{
    public class AllSumsCombination
    {
        public static List<List<int>> GetAllCombinations(int target)
        {
            var result = new List<List<int>>();
            if (target <= 0) {
                return result;
            }
           
            for (int j = 1; j < target; j++) {
                int temp = 0;
                Stack<int> stack = new Stack<int>();
                for (int i = j; i < target; i++)
                {
                    while (temp + i > target)
                    {
                        var pop = stack.Pop();
                        temp = temp - pop;
                    }

                    while (temp + i <= target)
                    {
                        temp = temp + i;
                        stack.Push(i);
                        if (temp == target)
                        {
                            result.Add(new List<int>(stack.ToArray()));
                        }
                    }
                }

            }

            result.Add(new List<int>{target});
            return result;
        }
    }
}
