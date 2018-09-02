using System;
namespace CodeRust.Arrays
{
    //https://www.geeksforgeeks.org/search-an-element-in-a-sorted-and-pivoted-array/
    public class SortedRotatedArray
    {

        public static int GetElementIndex(int[] array, int key)
        {
            if (array == null) { return -1; }
            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (array[mid] == key)
                {
                    return mid;
                }

                // Is left part sorted
                if(array[left] <= array[mid]) {
                    // l <= k < m
                    if (array[left] <= key && key < array[mid]) {
                        right = mid - 1;
                    } else {
                        left = mid + 1;
                    }

                } else {
                    // m < k <=r
                    if(array[mid] < key && key <= array[right]) {
                        left = mid + 1;
                    } else {
                        right = mid - 1;
                    }

                }

            }
            return -1;
        }

    }
}
