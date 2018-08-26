using CodeRust.Helpers;
using System.Collections.Generic;

namespace CodeRust.Matrix
{
    public class MatrixHelpers
    {
        public static void MatrixProblems()
        {
            var input = new int[3, 4] { { 2, 4, 9, 13 }, 
                                        { 3, 0, 11, 18 },
                                        { 6, 8, 16, 21 } };
            //PrintHelpers.PrintMatrix("Make Columns And Rows Zeros", input, x => MakeColumnAndRowZeros.MakeZero(input));

            //PrintHelpers.PrintMatrix("Search in a matrix", input, x => SearchInMatrix.Search(input, 11));

            //var points = new List<ClosestMeetingPoint.Point> { new ClosestMeetingPoint.Point(2, 1), new ClosestMeetingPoint.Point(2, 2), new ClosestMeetingPoint.Point(2, 3) };
            //input = new int[5, 5] {     { 0, 0, 0, 0, 0},
            //                            { 0, 0, 0, 0, 0 },
            //                            { 0, 1, 1, 1, 0 },
            //                            { 0, 0, 0, 0, 0 },
            //                            { 0, 0, 0, 0, 0 }
            //    };
            //PrintHelpers.PrintMatrix("Closest Meeting Point ", input, x => ClosestMeetingPoint.ClosestMeetingPt(points, 5));

            PrintHelpers.PrintMatrix("Print Spiral Matrix", input, x => SpiralMatrix.Spiral(input));
        }
    }
}
