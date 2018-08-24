using System.Collections.Generic;
using System.Text;

namespace CodeRust.MathAndStats
{
    public class KthPermutation
    {
        private static int fib(int n) {
            if(n < 2){
                return 1;
            }
            return n * fib(n - 1);
        }

        public static void Find_kth_permutation_rec(List<char> v, int k, StringBuilder result)
        {
            if (v.Count <= 0) {
                return;
            }
            int blockSize = fib(v.Count - 1);
            int selected = (k - 1) / blockSize;

            result.Append(v[selected]);
            v.Remove(v[selected]);
            k = k - selected * blockSize; // skipped blocks
            Find_kth_permutation_rec(v, k, result);

        }

        public static void Find_kth_permutation(List<char> v, int k, StringBuilder result)
        {
            while (v.Count > 0)
            {
                int blockSize = fib(v.Count - 1);
                int selected = (k - 1) / blockSize;

                result.Append(v[selected]);
                v.Remove(v[selected]);
                k = k - selected * blockSize; // skipped blocks
            }

        }
    }
}
