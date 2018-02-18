using System;
using System.Collections.Generic;

namespace CodeRust.Arrays
{
    public class CommonElementsInThreeSortedArray
    {
        public static int[] GetCommonElements(int[] array1, int[] array2, int[] array3)
        {
            List<int> result = new List<int>();
            int i = 0; int j = 0;  int k = 0;
            while(i < array1.Length && j < array2.Length && k < array3.Length)
            {
                if(array1[i] == array2[j] && array2[j] == array3[k])
                {
                    result.Add(array1[i]);
                    i++; j++; k++;
                }
                else if(array1[i] < array2[j])
                {
                    i++;
                }
                else if (array2[j] < array3[k])
                {
                    j++;
                }
                else
                {
                    k++;
                }
            }

            return result.ToArray();
        }
    }
}
