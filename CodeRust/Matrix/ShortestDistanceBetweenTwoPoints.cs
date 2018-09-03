using System.Collections.Generic;
namespace CodeRust.Matrix
{
    public class ShortestDistanceBetweenTwoPoints
    {
        public class QItem
        {
            public int Row { get; set; }
            public int Col { get; set; }
            public int Dist { get; set; }

            internal QItem(int row, int col, int dist)
            {
                Row = row;
                Col = col;
                Dist = dist;
            }
        };
        public static int GetShortestDistanceBetweenTwoPoints(char[,] input)
        {
            if (input == null) return -1;

            int rowMax = input.GetLength(0);
            int colMax = input.GetLength(1);
            bool[,] visited = new bool[rowMax, colMax];

            QItem source = null;
            //Find Source
            for (int i = 0; i < rowMax; i++) {
                for (int j = 0; j < colMax; j++) {
                    if (input[i,j] == 'S') {
                        source = new QItem(i, j, 0);
                        break;
                    }
                    if(input[i,j] == '0') {
                        visited[i, j] = true;
                    }
                }
            }

            if(source == null) {
                return -1;
            }
            Queue<QItem> queue = new Queue<QItem>();
            queue.Enqueue(source);

            while(queue.Count > 0) {
                var current = queue.Dequeue();

                if(input[current.Row, current.Col] == 'D') {
                    return current.Dist;
                }

                //Up
                if(current.Row - 1 >= 0 && !visited[current.Row - 1, current.Col]) {
                    queue.Enqueue(new QItem(current.Row - 1, current.Col, current.Dist + 1));
                    visited[current.Row - 1, current.Col] = true;
                }

                //Down
                if (current.Row + 1 < rowMax && !visited[current.Row + 1, current.Col])
                {
                    queue.Enqueue(new QItem(current.Row + 1, current.Col, current.Dist + 1));
                    visited[current.Row + 1, current.Col] = true;
                }

                //Left
                if (current.Col - 1 >= 0 && !visited[current.Row, current.Col - 1])
                {
                    queue.Enqueue(new QItem(current.Row, current.Col - 1, current.Dist + 1));
                    visited[current.Row, current.Col - 1] = true;
                }

                //Right
                if (current.Col + 1 < colMax && !visited[current.Row, current.Col + 1])
                {
                    queue.Enqueue(new QItem(current.Row, current.Col + 1, current.Dist + 1));
                    visited[current.Row, current.Col + 1] = true;
                }
            }
            return -1;
        }
    }
}
