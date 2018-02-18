using System.Collections.Generic;
//https://www.geeksforgeeks.org/sliding-window-maximum-maximum-of-all-subarrays-of-size-k/

namespace CodeRust.Arrays
{
    public class MaximumSlidingWindow
    {
        public static int[] GetMaximumElementPerWindow(int[] input, int window)
        {
            List<int> result = new List<int>();
            LinkedList<int> queue = new LinkedList<int>();
            int i = 0;
            for (i = 0; i < window; ++i)
            {
               
                while (queue.Count > 0 && input[i] >= input[queue.Last.Value])
                {
                    queue.RemoveLast();
                }
                queue.AddLast(i);
            }

            for (; i < input.Length; ++i)
            {
                result.Add(input[queue.First.Value]);

                // Remove out of window elements
                while(queue.Count> 0 && queue.First.Value <= i-window )
                {
                    queue.RemoveFirst();
                }

                //Remove all elements smaller than current
                while (queue.Count > 0 && input[i] >= input[queue.Last.Value])
                {
                    queue.RemoveLast();
                }

                queue.AddLast(i);
            }
            result.Add(input[queue.First.Value]);
            return result.ToArray();
        }
    }
}
