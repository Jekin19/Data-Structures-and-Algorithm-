using System.Collections.Generic;

namespace CodeRust.Arrays
{
    // https://www.geeksforgeeks.org/find-first-and-last-positions-of-an-element-in-a-sorted-array/
    public class FirstAndLast
    {
        public static int[] FindFirstAndLast(int[] input, int key)
        {
            List<int> results = new List<int>();
            results.Add(FindFirst(input, key, 0, input.Length-1));
            results.Add(FindLast(input, key, 0, input.Length-1));
            return results.ToArray();
        }

        static int FindFirst(int[] input, int key, int left, int right)
        {
            while (left < right)
            {
                int mid = (left + right) / 2;

                if ((mid == 0 || input[mid - 1] < key) && input[mid] == key)
                {
                    return mid;
                }
                else if(input[mid] < key)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }

        static int FindLast(int[] input, int key, int left, int right)
        {
            while (left < right)
            {
                int mid = (left + right) / 2;

                if ((mid == input.Length-1 || input[mid + 1] > key) && input[mid] == key)
                {
                    return mid;
                }
                else if (input[mid] < key)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }
}
