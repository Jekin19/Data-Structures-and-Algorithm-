using System.Collections.Generic;
//https://www.geeksforgeeks.org/sliding-window-maximum-maximum-of-all-subarrays-of-size-k/

namespace CodeRust.Arrays
{
    public class MaximumSlidingWindow
    {
        public static int[] GetMaximumElementPerWindow(int[] input, int window)
        {
            List<int> result = new List<int>();
            if (input == null || input.Length < 1 || window < 1) { return result.ToArray(); }

            LinkedList<int> linkedList = new LinkedList<int>();
            for (int i = 0; i < window; i++) {
                while(linkedList.Count > 0 && input[linkedList.Last.Value] <= input[i]){
                    linkedList.RemoveLast();
                }
                linkedList.AddLast(i);
            }

            for (int i = window; i < input.Length; i++) {
                result.Add(input[linkedList.First.Value]);

                while (linkedList.Count > 0 && linkedList.First.Value <= i - window)
                {
                    linkedList.RemoveFirst();
                }

                while (linkedList.Count > 0 && input[linkedList.Last.Value] <= input[i])
                {
                    linkedList.RemoveLast();
                }
                linkedList.AddLast(i);
            }
            result.Add(input[linkedList.First.Value]);

            return result.ToArray();
        }
    }
}
