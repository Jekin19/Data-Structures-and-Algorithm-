using System;
namespace CodeRust.String
{
    public class AllPalindromSubstrings
    {
        public static int FindAllPalindromSubstring(string input) {
            if (input == null || input.Length < 2) { return 0; }
            int count = 0;
            for (int i = 1; i < input.Length; i++) {
                count += GetPalindromCount(input, i - 1, i);
                if (i + 1 < input.Length)
                {
                    count += GetPalindromCount(input, i - 1, i + 1);
                }     
            }
            return count;
        }

        static int GetPalindromCount(string input, int start, int end) {
            int count = 0;
            while(start >= 0 && end < input.Length) {
                if(input[start] == input[end]) {
                    count++;
                    start--;
                    end++;
                } else {
                    break;
                }
                   
            }
            return count;
        }
    }
}
