using System.Collections.Generic;

namespace CodeRust.String
{
    public class StringSegmentation
    {
        public static bool CanSegmentString(string input, HashSet<string> dict)
        {
            if (input == null || dict == null) { return false; }
            HashSet<string> set = new HashSet<string>();
            for (int i = 1; i <= input.Length; i++) {
                var first = input.Substring(0, i);
                if(dict.Contains(first)) {
                    var second = input.Substring(i);
                    if(string.IsNullOrEmpty(second) || dict.Contains(second)) {
                        return true;
                    }
                    if(!set.Contains(second)) {
                        if(CanSegmentString(second, dict)) {
                            return true;
                        }
                        set.Add(second);
                    }
                }
            }
            return false;
        }
    }
}
