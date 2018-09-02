namespace CodeRust.Arrays
{
    public class RotateArray
    {
        //https://www.geeksforgeeks.org/array-rotation/

        public static int[] GetRotateArray(int[] input, int pivot)
        {
            if (input == null) { return input; }
            pivot = pivot % input.Length;
            if (pivot < 0)
            {
                pivot = input.Length + pivot;
            }
            Rotate(input, 0, input.Length - 1);
            Rotate(input, 0, pivot - 1);
            Rotate(input, pivot, input.Length - 1);
            return input;
        }

        static int[] Rotate(int[] input, int start, int end)
        {
            while (start < end)
            {
                int temp = input[end];
                input[end] = input[start];
                input[start] = temp;
                start++;
                end--;
            }
            return input;
        }
    }
}
