using System.Collections.Generic;
using System.Linq;

namespace CodeRust.MathAndStats
{
    public class PythagorasTriplet
    {
        public static List<List<int>> GetPythagorasTriplets(List<int> input)
        {
            var result = new List<List<int>>();
            if (input == null || input.Count < 3) { return result; }
            var sortedInput = input.OrderBy(i => i).ToList();
            for (int i = 3; i < sortedInput.Count(); i++) {
                int start = 0;
                int end = i - 1;
                while(start < end) {
                    if(sortedInput[start] * sortedInput[start] + sortedInput[end] * sortedInput[end] == sortedInput[i] * sortedInput[i]) {
                        result.Add(new List<int> { sortedInput[start], sortedInput[end], sortedInput[i] });
                        start++;
                        end--;
                    } else if (sortedInput[start] * sortedInput[start] + sortedInput[end] * sortedInput[end] < sortedInput[i] * sortedInput[i]) {
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
