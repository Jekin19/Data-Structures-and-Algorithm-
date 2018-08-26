using System;
namespace CodeRust.Matrix
{
    public class SpiralMatrix
    {
        public static void Spiral(int[,] arr) {
            if (arr == null) {
                return;
            }

            int colMin = 0;
            int colMax = arr.GetLength(1) - 1;
            int rowMin = 0;
            int rowMax = arr.GetLength(0) - 1;
          
            while (rowMin <= rowMax && colMin <= colMax) {

                // Go Right;
                int temp = colMin;
                while(temp <= colMax && rowMin <= rowMax && colMin <= colMax) {
                    Console.Write(arr[rowMin, temp] + "\t");
                    temp++;
                }

                // Go Down;
                rowMin++;
                temp = rowMin;
                while (temp <= rowMax && rowMin <= rowMax && colMin <= colMax)
                {
                    Console.Write(arr[temp, colMax] + "\t");
                    temp++;
                }

                // Go left;
                colMax--;
                temp = colMax;
                while (temp >= colMin && rowMin <= rowMax && colMin <= colMax)
                {
                    Console.Write(arr[rowMax, temp] + "\t");
                    temp--;
                }

                // Go Up;
                rowMax--;
                temp = rowMax;
                while (temp >= rowMin && rowMin <= rowMax && colMin <= colMax)
                {
                    Console.WriteLine(arr[temp, colMin] + "\t");
                    temp--;
                }

                colMin++;
            }
                
        }
    }
}
