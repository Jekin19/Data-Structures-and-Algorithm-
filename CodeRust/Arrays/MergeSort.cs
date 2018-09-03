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

        static void DoMerge(int[] numbers, int left, int mid, int right)

        {

           

            int i, eol, num, pos;

            eol = (mid - 1);

            pos = left;

            num = (right - left + 1);
            int[] temp = new int[num];

            while ((left <= eol) && (mid <= right))

            {

                if (numbers[left] <= numbers[mid])

                    temp[pos++] = numbers[left++];

                else

                    temp[pos++] = numbers[mid++];

            }


            while (left <= eol)

                temp[pos++] = numbers[left++];


            while (mid <= right)

                temp[pos++] = numbers[mid++];


            for (i = 0; i < num; i++)

            {

                numbers[right] = temp[right];

                right--;

            }
        }
    }
}
