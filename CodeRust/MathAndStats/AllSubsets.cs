using System;
using System.Collections.Generic;

namespace CodeRust.MathAndStats
{
    public class AllSubsets
    {
        static int get_bit(int num, int bit)
        {
            int temp = 1 << bit;
            temp = temp & num;
            return temp == 0 ? 0 : 1;
        }

        public static List<List<int>> Get_all_subsets(List<int> v)
        {
            List<List<int>> sets = new List<List<int>>();
            int subsets_count = (int)(Math.Pow(2, v.Count));
            for (int i = 0; i < subsets_count; ++i)
            {
                HashSet<int> set = new HashSet<int>();
                for (int j = 0; j < v.Count; j++ ) {
                    if(get_bit(i, j) == 1) {
                        set.Add(v[j]);
                    }
                }
                int[] arr = new int[set.Count];
                set.CopyTo(arr);
                sets.Add(new List<int>(set));
            }
            return sets;
        }
    }
}
