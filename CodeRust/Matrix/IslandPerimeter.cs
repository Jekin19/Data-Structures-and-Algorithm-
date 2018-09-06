using System;
namespace CodeRust.Matrix
{
    public class IslandPerimeter
    {
        public static int GetIslandPerimeter(int [,] matrix) {
            if (matrix == null) return -1;

            int rowMax = matrix.GetLength(0);
            int colMax = matrix.GetLength(1);

            int perimeter = 0;
            for (int i = 0; i < rowMax; i++) {
                for (int j = 0; j < colMax; j++) {
                    if(matrix[i,j] == 1) {
                        perimeter += 4 - GetNeighbors(matrix, i, j);
                    }
                }
            }

            return perimeter;
        }

        private static int GetNeighbors(int[,] matrix, int row, int col)
        {
            int count = 0;
            int rowMax = matrix.GetLength(0);
            int colMax = matrix.GetLength(1);

            //Up
            if (row - 1 >= 0 && matrix[row - 1, col] == 1)
            {
                count++;
            }

            //Down
            if (row + 1 < rowMax && matrix[row + 1, col] == 1)
            {
                count++;
            }

            //Right
            if (col + 1 < colMax && matrix[row, col + 1] == 1)
            {
                count++;
            }

            //Left
            if (col - 1 >= 0 && matrix[row, col - 1] == 1)
            {
                count++;
            }
            return count;
        }

    }

}
