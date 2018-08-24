using System.Collections.Generic;

namespace CodeRust.MathAndStats
{
    public class AllSumsCombination
    {
        public static List<List<int>> GetAllCombinations(int target)
        {
            List<List<int>> result = new List<List<int>>();

            List<int> output = new List<int>();
            int temp = 0;
            for (int i = 1; i < target; i++)
            {

                temp = temp + i;

                while (temp > target && output.Count > 0)
                {
                    var lastCount = output.Count - 1;
                    temp = temp - output[lastCount];
                    output.RemoveAt(lastCount);
                }

                while(temp <= target)
                {
                    output.Add(i);
                    if(temp == target)
                    {
                        result.Add(new List<int>(output));
                        break;
                    }
                    temp = temp + i;
                }
               
            }


            return result;
        }
    }
}
