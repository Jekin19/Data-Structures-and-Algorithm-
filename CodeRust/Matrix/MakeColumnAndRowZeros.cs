using System.Collections.Generic;

namespace CodeRust.Matrix
{
    public class MakeColumnAndRowZeros
    {
        //public static List<List<int>> MakeZero(int[,] input, int key)
        //{
        //    var result = new List<List<int>>();

        //    if (input == null)
        //    { 
        //        return null; 
        //    }

        //    var columnBound = input.GetUpperBound(1);
        //    var rowBound = 0;
        //    while(rowBound <= input.GetUpperBound(0) && columnBound >= 0)
        //    {
        //        if(input[rowBound, columnBound] == key )
        //        {
        //            result.Add(new List<int>{rowBound, columnBound}); 
        //            rowBound++;
        //            columnBound--;
        //        }
        //        else if (input[rowBound, columnBound] < key)
        //        {
        //            rowBound++;
        //        }
        //        else
        //        {
        //            columnBound--;
        //        }

        //    }


        //    return result;
        //}

        public static int[,] MakeZero(int[,] input)
        {
            if (input == null) {
                return null;
            }

            HashSet<int> rows = new HashSet<int>();
            HashSet<int> cols = new HashSet<int>();
            for (int i = 0; i < input.GetLength(0); i++) {
                for (int j = 0; j < input.GetLength(1); j++) {
                    if (input[i,j] == 0) {
                        rows.Add(i);
                        cols.Add(j);
                    }
                }
            }

            foreach(var row in rows) {
                for (int i = 0; i < input.GetLength(1); i++) {
                    input[row, i] = 0;
                }
            }

            foreach (var col in cols)
            {
                for (int i = 0; i < input.GetLength(0); i++)
                {
                    input[i, col] = 0;
                }
            }
            return input;
        }

    }
}
