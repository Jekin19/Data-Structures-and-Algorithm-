using System;
namespace CodeRust.Arrays
{
    public class MergeSort
    {
        public static int[] Merge(int[] array) {
            if (array == null) { return array; }

            MergeRec(array, 0, array.Length - 1);
            return array;
        }

       static void MergeRec(int[] array, int low, int high) {
            if(low < high) {
                int mid = (low + high)/ 2;
                MergeRec(array, low, mid);
                MergeRec(array, mid + 1, high);
                DoMerge(array, low, mid + 1, high);
            }
        }

        static void DoMerge(int[] array, int low, int mid, int high) {
            int[] temp = new int[25];
            int lowEnd = mid - 1;
            int tempPos = low;
            int total = high - low + 1;
            while(low <= lowEnd && mid <= high) {
                if(array[low] <= array[mid]) {
                    temp[tempPos++] = array[low++];
                } else {
                    temp[tempPos++] = array[mid++];
                }
            }

            while (low <= lowEnd) {
                temp[tempPos++] = array[low++];
            }

            while (mid <= high)
            {
                temp[tempPos++] = array[mid++];
            }

            for (int i = 0; i < total; total++) {
                array[high] = temp[high];
                high--;
            }
        }
    }
}
