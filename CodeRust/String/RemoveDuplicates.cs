using System.Collections.Generic;

namespace CodeRust.String
{
    public class RemoveDuplicates
    {
        public static string RemoveDuplicate(char[] str)
        {
            if (str == null || str.Length < 2) { return new string(str); }

            int readIndex = 0, writeIndex = 0;
            HashSet<char> set = new HashSet<char>();
            while(readIndex < str.Length) {
                if(!set.Contains(str[readIndex])) {
                    set.Add(str[readIndex]);
                    str[writeIndex] = str[readIndex];
                    writeIndex++;
                }
                readIndex++;
            }

            return new string(str, 0, writeIndex);
        }
    }
}
