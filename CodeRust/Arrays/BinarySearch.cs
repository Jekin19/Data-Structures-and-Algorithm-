namespace CodeRust.Arrays
{
    public class BinarySearch
    {
        public static int GetElementIndex(int[] array, int key)
        {
            int left = 0;
            int right = array.Length - 1;
            while(left <= right)
            {
                int mid = (left + right)/ 2;
                if(array[mid] == key)
                {
                    return mid;
                }
                else if(array[mid] < key)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }

        public static int GetElementIndexRecursively(int[] array, int key)
        {
            int left = 0;
            int right = array.Length - 1;
            return FindElementIndex(array, key, left, right);
        }

        public static int FindElementIndex(int[] array, int key, int left, int right)
        {
            if(left > right)
            {
                return -1;   
            }

            int mid = (left + right) / 2;
            if (array[mid] == key)
            {
                return mid;
            }
            else if (array[mid] < key)
            {
               return FindElementIndex(array, key, mid + 1, right);
            }
            else
            {
                return FindElementIndex(array, key, mid + 1, mid - 1);
            }
        }
    }
}
