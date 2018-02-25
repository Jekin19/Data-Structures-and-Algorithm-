namespace CodeRust.Matrix
{
    public class MatrixHelpers
    {
        public static void MatrixProblems()
        {
            var input = new int[3, 4] { { 2, 4, 9, 13 }, { 3, 5, 11, 18 }, { 6, 8, 16, 21 } };
            Matrix.MakeColumnAndRowZeros.MakeZero(input, 16);
        }
    }
}
