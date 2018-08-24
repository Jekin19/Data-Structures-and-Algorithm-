using System.Collections.Generic;
using System.Linq;

namespace CodeRust.MathAndStats
{
    public class PythagorasTriplet
    {
        public static List<List<int>> GetPythagorasTriplets(List<int> input) {
            var result = new List<List<int>>();
            if (input.Count < 3) {
                return result;
            }
            var array = input.OrderBy(i => i).ToList();

            for (int i = 2; i < array.Count; i++) {
                FindPythagorasTriple(array, result, i);
            }
            return result;
        }

        private static void FindPythagorasTriple(List<int> array, List<List<int>> result, int current) {
            int start = 0;
            int end = current - 1;
            while(start < end) {
                if (array[start] * array[start] + array[end] * array[end] < array[current] * array[current]) {
                    start++;
                } else if (array[start] * array[start] + array[end] * array[end] > array[current] * array[current]) {
                    end--;
                } else {
                    result.Add(new List<int> { array[start], array[end], array[current] });
                    break;
                }
            }
        }
    }
}
