using CodeRust.Helpers;
using System;
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
            PrintHelpers.PrintMatrix("Make Columns And Rows Zeros", input, x => MakeColumnAndRowZeros.MakeZero(input));

            input = new int[3, 4] { { 2, 4, 9, 13 },
                                        { 3, 0, 11, 18 },
                                        { 6, 8, 16, 21 } };
            PrintHelpers.PrintMatrix("Search in a matrix", input, x => SearchInMatrix.Search(input, 11));

            var points = new List<ClosestMeetingPoint.Point> { new ClosestMeetingPoint.Point(2, 1), new ClosestMeetingPoint.Point(2, 2), new ClosestMeetingPoint.Point(2, 3) };
            input = new int[5, 5] {     { 0, 0, 0, 0, 0},
                                        { 0, 0, 0, 0, 0 },
                                        { 0, 1, 1, 1, 0 },
                                        { 0, 0, 0, 0, 0 },
                                        { 0, 0, 0, 0, 0 }
                };
            PrintHelpers.PrintMatrix("Closest Meeting Point ", input, x => ClosestMeetingPoint.ClosestMeetingPt(points, 5));

            input = new int[3, 4] {     { 2, 4, 9, 13 },
                                        { 3, 0, 11, 18 },
                                        { 6, 8, 16, 21 } };
            PrintHelpers.PrintMatrix("Print Spiral Matrix", input, x => SpiralMatrix.Spiral(input));

            input = new int[5, 5] {     { 0, 0, 0, 0, 0},
                                        { 0, 0, 0, 0, 0 },
                                        { 0, 1, 1, 1, 0 },
                                        { 0, 0, 0, 0, 0 },
                                        { 0, 0, 0, 0, 0 }
                };
            PrintHelpers.PrintMatrix("Island", input, x => IslandCount.NumIslands(input));

            var charInput = new Char[4, 4] {    { '0', '0', '1', 'S' },
                                                { '0', '1', '1', '0' },
                                                { '0', '1', '1', '0' },
                                                { '0', '0', '1', 'D' }
                                        };
            PrintHelpers.PrintMatrix("Shortest Distance", charInput, x => ShortestDistanceBetweenTwoPoints.GetShortestDistanceBetweenTwoPoints(charInput));

            var boggleInput = new Char[3, 3] {  {'c', 'a', 't'},
                                                {'r', 'r', 'e'},
                                                {'t', 'o', 'n'}
            };

            var boggleDict = new HashSet<string>
            {
                "art",
                "cat",
                "cater",
                "cartoon",
                "toon",
                "moon",
                "not",
                "apple",
                "ton"
            };
            PrintHelpers.PrintMatrix("Boggle", boggleInput, x => Boggle.GetAllWords(boggleInput, boggleDict));

            input = new int[5, 5] {     { 0, 0, 0, 0, 0},
                                        { 0, 0, 0, 0, 0 },
                                        { 0, 0, 0, 0, 0 },
                                        { 0, 0, 0, 0, 0 },
                                        { 0, 0, 0, 0, 0 }
                };
            PrintHelpers.PrintMatrix("N Queen Problem", input, x => NQueenProblem.GetNQueens(input.GetLength(0)));

            input = new int[3, 4] {     { 2, 4, 9, 13 },
                                        { 3, 0, 11, 18 },
                                        { 6, 8, 16, 21 } };

            PrintHelpers.PrintMatrix("Diagonal Matrix", input, x => DiagonaMatrixTraversal.TraverseMatrix(input));

            input = new int[4, 4] {     { 0, 1, 0, 0 },
                                        { 1, 1, 1, 0 },
                                        { 0, 1, 0, 0 },
                                        { 1, 1, 0, 0 }
                };
            PrintHelpers.PrintMatrix("Island Perimeter", input, x => IslandPerimeter.GetIslandPerimeter(input));


        }

    }
}
