using System;
namespace CodeRust.Matrix
{
    public class LongestCommonSubstring
    {
        public static int GetLongestCommonSubstring(string s1, string s2){
            int result = 0;
            int[,] table = new int[s1.Length, s2.Length];
            for (int i = 0; i < s1.Length; i++) {
                for (int j = 0; j < s2.Length; j++) {
                    int current = s1[i] == s2[j] ? 1 : 0;
                    if(i ==0 || j==0) {
                        table[i, j] = current;
                    } else {
                        table[i, j] = current + table[i - 1, j - 1];
                    }
                    result = Math.Max(result, table[i, j]);
                }
            }
            return result;
        }
    }
}
