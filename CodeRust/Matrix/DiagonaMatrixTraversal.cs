using System.Collections.Generic;
using System;

namespace CodeRust.Matrix
{
    public static class DiagonaMatrixTraversal
    {
        public static void TraverseMatrix(int[,] matrix) 
        {
            var result = new List<int>();
            if (matrix == null) { return; }

            Traverse(matrix, result, true);
            Traverse(matrix, result, false);

            //Print result;
            result.ForEach(res => Console.Write(res + " "));
        }

        private static void Traverse(int[,] matrix, List<int> result, bool rowTraversal){
        
            int rowMax = matrix.GetLength(0);
            int colMax = matrix.GetLength(1);

            int start = rowTraversal ? 0 : 1;
            int end = rowTraversal ? rowMax : colMax;

            for (int i = start; i < end; i++)
            {
                int tempRow = rowTraversal ? i : rowMax - 1;
                int tempCol = rowTraversal ? 0 : i;
                while (tempRow >= 0 && tempCol < colMax)
                {
                    result.Add(matrix[tempRow, tempCol]);
                    tempRow--;
                    tempCol++;
                }
            }
        }
    }
}
