using System.Collections.Generic;
namespace CodeRust.MathAndStats
{
    public class FindMissingNumber
    {
        public static int Find_missing(List<int> input)
        {
            //TODO: Write - Your - Code
            // n(n+1)/2
            int totalSum = ((input.Count + 1) * (input.Count + 2)) / 2;
            for (int i = 0; i < input.Count; i++)
            {
                totalSum = totalSum - input[i];
            }
            return totalSum;
        }
    }
}
