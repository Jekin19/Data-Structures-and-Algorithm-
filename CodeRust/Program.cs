using System;
using CodeRust.Arrays;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace CodeRust
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays

            //Binary Search
            int[] input = { 1, 3, 7, 9, 10, 15, 20 };
            PrintArray("Binary Search", input, new[] { BinarySearch.GetElementIndex(input, 9) }, "K = 9");
            PrintArray("Binary Search Recursively", input, new[] { BinarySearch.GetElementIndexRecursively(input, 9) }, "K = 9");

            // Maximum Sliding Window
            input = new int[] { 8, 5, 10, 7, 9, 4, 15, 12, 90, 13};
            var ouput = MaximumSlidingWindow.GetMaximumElementPerWindow(input, 4);
            PrintArray("Maximum Sliding Window", input, ouput, "Window Size = 4");

            //Sorted Rotate Array Search
            input = new int[]{ 5, 6, 7, 8, 9, 10, 1, 2, 3 };
            PrintArray("Sorted Rotate Array", input, new[] { SortedRotatedArray.GetElementIndex(input, 3) },"K = 3");
           

            Console.ReadKey();
        }

        static void PrintArray<T>(string header, IList<T> input, IList<T> output, string specialInput = null)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("----------- {0} ---------",header));

            // input
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Count(); i++)
            {
                sb.Append(input[i]);
                sb.Append(", ");
            }
            sb.Remove(sb.Length - 2, 2);
            stringBuilder.AppendLine(string.Format("Input: [{0}] {1}",sb,specialInput));

            //Output
            sb = new StringBuilder();
            for (int i = 0; i < output.Count(); i++)
            {
                sb.Append(output[i]);
                sb.Append(", ");
            }
            sb.Remove(sb.Length-2,2);
            stringBuilder.AppendLine(string.Format("Output: [{0}]", sb));

            stringBuilder.AppendLine(string.Format("---------------------------------------------------"));
            Console.WriteLine(stringBuilder);
        }
    }
}
