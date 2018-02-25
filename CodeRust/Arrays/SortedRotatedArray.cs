using System;
namespace CodeRust.Arrays
{
    //https://www.geeksforgeeks.org/search-an-element-in-a-sorted-and-pivoted-array/
    public class SortedRotatedArray
    {

        public static int GetElementIndex(int[] array, int key)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (array[mid] == key)
                {
                    return mid;
                }
                if (array[mid] < key)
                {
                    if (key <= array[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                else
                {
                    if (key >= array[left])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                
                }

            }
            return -1;
        }

    }
}
