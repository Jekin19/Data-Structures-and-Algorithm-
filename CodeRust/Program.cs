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

            //Common elements in sorted Array
            int[] array1 = { 1, 5, 10, 20, 40, 80 };
            int[] array2 = { 6, 7, 20, 80, 100 };
            int[] array3 = { 3, 4, 15, 20, 30, 70, 80, 120 };
            PrintArray("Common elements in sorted Array", new []{array1, array2, array3}, CommonElementsInThreeSortedArray.GetCommonElements(array1,array2,array3));      


            //Rotated Array
            input = new int[]{ 1, 3, 7, 9, 10, 15, 20 };
            int[] input2 = new int[] { 1, 3, 7, 9, 10, 15, 20 };
            PrintArray("Rotate Array", input, RotateArray.GetRotateArray(input2, 3), "Pivot = 3");

            //First and Last Index 
            input = new int[] { 1, 3, 5, 5, 5, 5, 7, 123, 125 };
            PrintArray("First and Last Index for input", input, FirstAndLast.FindFirstAndLast(input, 7), "Input = 7");

            Console.ReadKey();
        }

        static void PrintArray<T>(string header, IList<T> input, IList<T> output, string specialInput = null)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("----------- {0} ---------",header));

            stringBuilder.AppendLine(string.Format("Input: [{0}] {1}",GetInput(input),specialInput));

            stringBuilder.AppendLine(GetOuput(output));

            stringBuilder.AppendLine(string.Format("---------------------------------------------------"));
            Console.WriteLine(stringBuilder);
        }

        static void PrintArray<T>(string header, IEnumerable<IList<T>> inputs, IList<T> output)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("----------- {0} ---------", header));

            stringBuilder.AppendLine("Input: ");
            stringBuilder.AppendLine(GetInput(inputs));

            stringBuilder.AppendLine(GetOuput(output));

            stringBuilder.AppendLine(string.Format("---------------------------------------------------"));
            Console.WriteLine(stringBuilder);
        }

        static string GetOuput<T>(IList<T> output)
        {
            //Output
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < output.Count(); i++)
            {
                sb.Append(output[i]);
                sb.Append(", ");
            }
            sb.Remove(sb.Length - 2, 2);
            return string.Format("Output: [{0}]", sb);
        }

        static string GetInput<T>(IList<T> input)
        { 
            // input
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Count(); i++)
            {
                sb.Append(input[i]);
                sb.Append(", ");
            }
            sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }

        static string GetInput<T>(IEnumerable<IList<T>> inputs)
        {
            // input
            StringBuilder stringBuilder = new StringBuilder();
            int counter = 0;
            inputs.ToList().ForEach( input =>
            {
                counter++;
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < input.Count(); i++)
                {
                    sb.Append(input[i]);
                    sb.Append(", ");
                }
                sb.Remove(sb.Length - 2, 2);
                stringBuilder.AppendLine(string.Format("Input {0}: {1}",counter, sb));
            });
            return stringBuilder.ToString();
        }
    }
}
