using CodeRust.Helpers;
using System.Collections.Generic;

namespace CodeRust.Arrays
{
    public class ArrayHelpers
    {
        public static void ArrayProblems()
        {
            //Arrays

            //Binary Search
            int[] input = { 1, 3, 7, 9, 10, 15, 20 };
            PrintHelpers.PrintArray("Binary Search", input, new[] { BinarySearch.GetElementIndex(input, 9) }, "K = 9");
            PrintHelpers.PrintArray("Binary Search Recursively", input, new[] { BinarySearch.GetElementIndexRecursively(input, 9) }, "K = 9");

            // Maximum Sliding Window
            input = new int[] { 8, 5, 10, 7, 9, 4, 15, 12, 90, 13 };
            var ouput = MaximumSlidingWindow.GetMaximumElementPerWindow(input, 4);
            PrintHelpers.PrintArray("Maximum Sliding Window", input, ouput, "Window Size = 4");

            //Sorted Rotate Array Search
            input = new int[] { 5, 6, 7, 8, 9, 10, 1, 2, 3 };
            PrintHelpers.PrintArray("Sorted Rotate Array", input, new[] { SortedRotatedArray.GetElementIndex(input, 3) }, "K = 3");

            //Common elements in sorted Array
            int[] array1 = { 1, 5, 10, 20, 40, 80 };
            int[] array2 = { 6, 7, 20, 80, 100 };
            int[] array3 = { 3, 4, 15, 20, 30, 70, 80, 120 };
            PrintHelpers.PrintArray("Common elements in sorted Array", new[] { array1, array2, array3 }, CommonElementsInThreeSortedArray.GetCommonElements(array1, array2, array3));


            //Rotated Array
            input = new int[] { 1, 3, 7, 9, 10, 15, 20 };
            int[] input2 = { 1, 3, 7, 9, 10, 15, 20 };
            PrintHelpers.PrintArray("Rotate Array", input, RotateArray.GetRotateArray(input2, 3), "Pivot = 3");

            //First and Last Index 
            input = new int[] { 1, 3, 5, 5, 5, 5, 7, 123, 125 };
            PrintHelpers.PrintArray("First and Last Index for input", input, FirstAndLast.FindFirstAndLast(input, 7), "Input = 7");

            //Move Zeros to Left
            input = new int[] { 1, 2, 3, 0, 0, 0, 4, 5 };
            input2 = new int[] { 1, 2, 3, 0, 0, 0, 4, 5 };
            PrintHelpers.PrintArray("Move Zeros to Left", input2, MoveZeroesToLeft.ShiftZeros(input));

            //Buy Sell max Profit
            input = new int[] { 10, 22, 5, 75, 65, 80 };
            PrintHelpers.PrintArray("Buy Sell max Profit", input, BuySellMaxProfit.GetBuySellIndex(input));

            //Sum of Two Values
            input = new int[] { 5, 7, 1, 2, 8, 4, 3 };
            PrintHelpers.PrintArray("Sum of Two Values", input, SumOfTwoValues.GetPairs(input, 10), "Sum = 10");

            //Merging Intervals
            var inputList = new List<List<int>>();
            inputList.Add(new List<int> { 1, 3 });
            inputList.Add(new List<int> { 2, 4 });
            inputList.Add(new List<int> { 5, 7 });
            inputList.Add(new List<int> { 6, 8 });
            var inputList2 = new List<List<int>>();
            inputList.Add(new List<int> { 1, 3 });
            inputList.Add(new List<int> { 2, 4 });
            inputList.Add(new List<int> { 5, 7 });
            inputList.Add(new List<int> { 6, 8 });
            PrintHelpers.PrintArrays("Merging Intervals", inputList2, MergeIntervals.Merge(inputList));

            //Quick Sort
            input = new int[] { 5, 7, 1, 2, 8, 4, 3 };
            input2 = new int[] { 5, 7, 1, 2, 8, 4, 3 };
            PrintHelpers.PrintArray("Quick Sort", input2, QuickSort.Sort(input));
        }
             

    }
}
