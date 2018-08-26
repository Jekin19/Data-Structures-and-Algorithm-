
namespace CodeRust.Matrix
{
    public class SearchInMatrix
    {
        public static int[,] Search(int [,] input, int key) {
            int[,] result = new int[1, 2];
            if (input == null) return null;

            int rows = input.GetLength(0);
            int cols = input.GetLength(1);
            int row = 0;
            int col = cols - 1;
            while(col >=0 && row < rows) {
                if(input[row, col] == key) {
                    result[0, 0] = row;
                    result[0, 1] = col;
                    return result;
                }
                if (input[row,col] < key) {
                    row++;
                } else {
                    col--;
                }
            }
            return result;
        }
    }
}
