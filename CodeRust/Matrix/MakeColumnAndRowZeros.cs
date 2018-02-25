using System.Collections.Generic;

namespace CodeRust.Matrix
{
    public class MakeColumnAndRowZeros
    {
        public static List<List<int>> MakeZero(int[,] input, int key)
        {
            var result = new List<List<int>>();

            if (input == null)
            { 
                return null; 
            }

            var columnBound = input.GetUpperBound(1);
            var rowBound = 0;
            while(rowBound <= input.GetUpperBound(0) && columnBound >= 0)
            {
                if(input[rowBound, columnBound] == key )
                {
                    result.Add(new List<int>{rowBound, columnBound}); 
                    rowBound++;
                    columnBound--;
                }
                else if (input[rowBound, columnBound] < key)
                {
                    rowBound++;
                }
                else
                {
                    columnBound--;
                }

            }
           

            return result;
        }
    }
}
