using System;
using CodeRust.Arrays;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using CodeRust.LinkedLists;

namespace CodeRust
{
    class Program
    {
        static void Main()
        {

            //Arrays
           // ArrayProblems();

            // Linked List

            // Reverse a linked list
            LinkedList<int> linked = new LinkedList<int>();
            linked.AddLast(1);
            linked.AddLast(2);
            linked.AddLast(3);
            LinkedList<int> linked2 = new LinkedList<int>();
            linked2.AddLast(1);
            linked2.AddLast(2);
            linked2.AddLast(3);
            PrintArray("Reverse Linked List", linked2.ToArray(), ReverseLinkedList.Reverse(linked).ToArray());


            // Remove duplicates in a linked list
            linked = new LinkedList<int>();
            linked.AddLast(1);
            linked.AddLast(2);
            linked.AddLast(2);
            linked.AddLast(3);
            linked2 = new LinkedList<int>();
            linked2.AddLast(1);
            linked2.AddLast(2);
            linked2.AddLast(2);
            linked2.AddLast(3);
            PrintArray("Remove Duplicates", linked2.ToArray(), RemoveDuplicates.RemoveDuplicate(linked).ToArray());


            Console.ReadKey();
        }

        private static void ArrayProblems()
        {
            //Arrays

            //Binary Search
            int[] input = { 1, 3, 7, 9, 10, 15, 20 };
            PrintArray("Binary Search", input, new[] { BinarySearch.GetElementIndex(input, 9) }, "K = 9");
            PrintArray("Binary Search Recursively", input, new[] { BinarySearch.GetElementIndexRecursively(input, 9) }, "K = 9");

            // Maximum Sliding Window
            input = new int[] { 8, 5, 10, 7, 9, 4, 15, 12, 90, 13 };
            var ouput = MaximumSlidingWindow.GetMaximumElementPerWindow(input, 4);
            PrintArray("Maximum Sliding Window", input, ouput, "Window Size = 4");

            //Sorted Rotate Array Search
            input = new int[] { 5, 6, 7, 8, 9, 10, 1, 2, 3 };
            PrintArray("Sorted Rotate Array", input, new[] { SortedRotatedArray.GetElementIndex(input, 3) }, "K = 3");

            //Common elements in sorted Array
            int[] array1 = { 1, 5, 10, 20, 40, 80 };
            int[] array2 = { 6, 7, 20, 80, 100 };
            int[] array3 = { 3, 4, 15, 20, 30, 70, 80, 120 };
            PrintArray("Common elements in sorted Array", new[] { array1, array2, array3 }, CommonElementsInThreeSortedArray.GetCommonElements(array1, array2, array3));


            //Rotated Array
            input = new int[] { 1, 3, 7, 9, 10, 15, 20 };
            int[] input2 = { 1, 3, 7, 9, 10, 15, 20 };
            PrintArray("Rotate Array", input, RotateArray.GetRotateArray(input2, 3), "Pivot = 3");

            //First and Last Index 
            input = new int[] { 1, 3, 5, 5, 5, 5, 7, 123, 125 };
            PrintArray("First and Last Index for input", input, FirstAndLast.FindFirstAndLast(input, 7), "Input = 7");

            //Move Zeros to Left
            input = new int[] { 1, 2, 3, 0, 0, 0, 4, 5 };
            input2 = new int[] { 1, 2, 3, 0, 0, 0, 4, 5 };
            PrintArray("Move Zeros to Left", input2, MoveZeroesToLeft.ShiftZeros(input));

            //Buy Sell max Profit
            input = new int[] { 10, 22, 5, 75, 65, 80 };
            PrintArray("Buy Sell max Profit", input, BuySellMaxProfit.GetBuySellIndex(input));

            //Sum of Two Values
            input = new int[] { 5, 7, 1, 2, 8, 4, 3 };
            PrintArray("Sum of Two Values", input, SumOfTwoValues.GetPairs(input, 10), "Sum = 10");

            //Merging Intervals
            List<List<int>> inputList = new List<List<int>>();
            inputList.Add(new List<int> { 1, 3 });
            inputList.Add(new List<int> { 2, 4 });
            inputList.Add(new List<int> { 5, 7 });
            inputList.Add(new List<int> { 6, 8 });
            PrintArray("Merging Intervals", inputList, MergeIntervals.Merge(inputList));

            //Quick Sort
            input = new int[] { 5, 7, 1, 2, 8, 4, 3 };
            input2 = new int[] { 5, 7, 1, 2, 8, 4, 3 };
            PrintArray("Quick Sort", input2, QuickSort.Sort(input));
        }

        static void PrintArray<T>(string header, IList<T> input, IList<T> output, string specialInput = null)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("----------- {0} ---------",header));

            stringBuilder.AppendLine(string.Format("{0} {1}",GetInputOuput(input),specialInput));

            stringBuilder.AppendLine(GetInputOuput(output,"Output"));

            stringBuilder.AppendLine(string.Format("---------------------------------------------------"));
            Console.WriteLine(stringBuilder);
        }

        static void PrintArray<T>(string header, IEnumerable<IList<T>> inputs, IList<T> output, string specialInput = null)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("----------- {0} ---------", header));

            stringBuilder.AppendLine("Input: ");
            stringBuilder.AppendLine(string.Format("{0} {1}", GetInputOuputs(inputs), specialInput));

            stringBuilder.AppendLine(GetInputOuput(output,"Output"));

            stringBuilder.AppendLine(string.Format("---------------------------------------------------"));
            Console.WriteLine(stringBuilder);
        }

        static void PrintArray<T>(string header, IList<T> input, IEnumerable<IList<T>> output, string specialInput = null)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("----------- {0} ---------", header));

            stringBuilder.AppendLine(string.Format("{0} {1}", GetInputOuput(input), specialInput));

            stringBuilder.AppendLine(GetInputOuputs(output,"Output"));

            stringBuilder.AppendLine(string.Format("---------------------------------------------------"));
            Console.WriteLine(stringBuilder);
        }

        static void PrintArray<T>(string header, IEnumerable<IList<T>> inputs, IEnumerable<IList<T>> output, string specialInput = null)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("----------- {0} ---------", header));

            stringBuilder.AppendLine("Input: ");
            stringBuilder.AppendLine(string.Format("{0} {1}", GetInputOuputs(inputs), specialInput));

            stringBuilder.AppendLine(GetInputOuputs(output, "Output"));

            stringBuilder.AppendLine(string.Format("---------------------------------------------------"));
            Console.WriteLine(stringBuilder);
        }

        static string GetInputOuput<T>(IList<T> output, string comment = "Input")
        {
            //Output
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < output.Count(); i++)
            {
                sb.Append(output[i]);
                sb.Append(", ");
            }
            sb.Remove(sb.Length - 2, 2);
            return string.Format("{0}: [{1}]",comment, sb);
        }

        static string GetInputOuputs<T>(IEnumerable<IList<T>> inputs, string comment= "Input")
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
                stringBuilder.AppendLine(string.Format("{0} {1}: {2}",comment, counter, sb));
            });
            return stringBuilder.ToString();
        }
    }
}
