using System;
using System.Collections.Generic;
namespace CodeRust.Matrix
{
    public class IslandCount
    {
        public static int NumIslands(int[,] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }

            int nr = grid.GetLength(0);
            int nc = grid.GetLength(1);
            int num_islands = 0;

            for (int r = 0; r < nr; ++r)
            {
                for (int c = 0; c < nc; ++c)
                {
                    if (grid[r, c] == 1)
                    {
                        ++num_islands;
                        grid[r, c] = 0; // mark as visited
                        Queue<List<int>> neighbors = new Queue<List<int>>();
                        neighbors.Enqueue(new List<int> { r, c });
                        while (neighbors.Count > 0)
                        {
                            var id = neighbors.Dequeue();
                            int row = id[0];
                            int col = id[1];
                            if (row - 1 >= 0 && grid[row - 1, col] == 1)
                            {
                                neighbors.Enqueue(new List<int> { row - 1, col });
                                grid[row - 1, col] = 0;
                            }
                            if (row + 1 < nr && grid[row + 1, col] == 1)
                            {
                                neighbors.Enqueue(new List<int>{row + 1, col});
                                grid[row + 1, col] = 0;
                            }
                            if (col - 1 >= 0 && grid[row, col - 1] == 1)
                            {
                                neighbors.Enqueue(new List<int>{row, col-1});
                                grid[row, col - 1] = 0;
                            }
                            if (col + 1 < nc && grid[row, col + 1] == 1)
                            {
                                neighbors.Enqueue(new List<int> { row, col + 1 });
                                grid[row, col + 1] = 0;
                            }
                        }
                    }
                }
            }

            return num_islands;
        }

    }
}
