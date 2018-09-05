using System.Collections.Generic;
using System;
using System.Linq;

namespace CodeRust.Matrix
{
    public class QueenItem
    {
        public List<QueenItem> QueenList = new List<QueenItem>();
        public int Row { get; set; }
        public int Col { get; set; }
        public bool[,] Visited { get; set; }
        private int rowMax;
        private int colMax;

        public int Size{ get { return QueenList.Count; }}

        public QueenItem(int row, int col, int rowMax, int colMax)
        {

            Row = row;
            Col = col;
            Visited = new bool[rowMax+1, colMax+1];
            this.rowMax = rowMax;
            this.colMax = colMax;
        }

        public bool IsSafe(int row, int col ) {
            return !Visited[row, col];
        }

        public bool AddQueen(QueenItem queenItem)
        {
            MarkRowVisited(queenItem.Row);
            MarkColVisited(queenItem.Col);
            MarkDiagonalLeftUpVisited(queenItem.Row, queenItem.Col);
            MarkDiagonalRightUpVisited(queenItem.Row, queenItem.Col);
            MarkDiagonalLeftDownVisited(queenItem.Row, queenItem.Col);
            MarkDiagonalRightDownVisited(queenItem.Row, queenItem.Col);
            QueenList.Add(queenItem);
            return true;
        }

        private void MarkRowVisited(int row)
        {
            for (int i = 0; i <= colMax; i++)
            {
                Visited[row, i] = true;
            }
        }

        private void MarkColVisited(int col)
        {
            for (int i = 0; i <= rowMax; i++)
            {
                Visited[i, col] = true;
            }
        }

        private void MarkDiagonalLeftUpVisited(int row, int col)
        {
            while (row >= 0 && col >= 0)
            {
                Visited[row, col] = true;
                row--; col--;
            }
        }

        private void MarkDiagonalRightDownVisited(int row, int col)
        {
            while (row <= rowMax && col <= colMax)
            {
                Visited[row, col] = true;
                row++; col++;
            }
        }


        void MarkDiagonalRightUpVisited(int row, int col)
        {
            while (row >= 0 && col <= colMax)
            {
                Visited[row, col] = true;
                row--; col++;
            }
        }

        private void MarkDiagonalLeftDownVisited(int row, int col)
        {
            while (row <= rowMax && col >=0)
            {
                Visited[row, col] = true;
                row++; col--;
            }
        }


    }
    public class NQueenProblem
    {
        public static int GetNQueens(int n)
        {
            var result = new List<List<QueenItem>>();
            int min = Int32.MinValue;
            for (int i = 0; i < n; i++) {
                var current = new QueenItem(i, 0, n - 1, n - 1);
                current.AddQueen(current);
                Queue<QueenItem> queue = new Queue<QueenItem>();
                queue.Enqueue(current);
                while(queue.Count > 0) {
                    var currentItem = queue.Dequeue();
                    if (currentItem.Size == min)
                    {
                        result.Add(currentItem.QueenList);
                    }
                    if (currentItem.Size > min)
                    {
                        result = new List<List<QueenItem>>
                        {
                            currentItem.QueenList
                        };
                        min = currentItem.Size;
                    }
                    if (currentItem.Col + 1 < n) {
                        for (int j = 0; j < n; j++) {
                            if(currentItem.IsSafe(j, currentItem.Col + 1)) {
                                var newItem = new QueenItem(j, currentItem.Col + 1, n - 1, n - 1);
                                currentItem.QueenList.ForEach(item => newItem.AddQueen(item));
                                newItem.AddQueen(newItem);
                                queue.Enqueue(newItem);
                            }
                        }
                    }
                }
            }
            return min == n ? result.Count : 0;
        }
    }
}
