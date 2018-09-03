using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRust.Matrix
{
    public class BoggleItem {
        public string Word { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
        public bool[,] Visited { get; set; }

        public BoggleItem(int row, int col, string word, int rowMax = 100, int colMax = 100) {
            Word = word;
            Row = row;
            Col = col;
            Visited = new bool[rowMax, colMax];
        }
    }

   
    public class Boggle
    {
        private static bool[,] CopyVisitedNode(bool [,] current) {
            var tempVisited = new bool[current.GetLength(0), current.GetLength(1)];
            for (int tempI = 0; tempI < current.GetLength(0); tempI++)
            {
                for (int tempk = 0; tempk < current.GetLength(1); tempk++)
                {
                    tempVisited[tempI, tempk] = current[tempI, tempk];
                }
            }
            return tempVisited;
        }

        public static string GetAllWords(char[,] boggleMatrix, HashSet<string> dict) {
            var result = new HashSet<string>();
            var printerOutput = new StringBuilder();
            var rowMax = boggleMatrix.GetLength(0);
            var colMax = boggleMatrix.GetLength(1);

            for (int i = 0; i < rowMax; i++) {
              
                for (int j = 0; j < colMax; j++ ) {
                    Queue<BoggleItem> queue = new Queue<BoggleItem>();
                    var currentItem = new BoggleItem(i , j, boggleMatrix[i, j].ToString(), rowMax, colMax);
                    queue.Enqueue(currentItem);

                    while (queue.Count > 0) {
                        var current = queue.Dequeue();
                        current.Visited[current.Row, current.Col] = true;

                        if (dict.Contains(current.Word)){
                            if(!result.Contains(current.Word)) {
                                result.Add(current.Word);
                            }

                        }

                        //Up
                        if (current.Row - 1 >= 0 && !current.Visited[current.Row - 1, current.Col])
                        {
                            var tempVisited = CopyVisitedNode(current.Visited);
                            queue.Enqueue(new BoggleItem(current.Row - 1, current.Col, current.Word + boggleMatrix[current.Row - 1, current.Col]) {Visited = tempVisited });
                           
                        }

                        //Down
                        if (current.Row + 1 < rowMax && !current.Visited[current.Row + 1, current.Col])
                        {
                            var tempVisited = CopyVisitedNode(current.Visited);
                            queue.Enqueue(new BoggleItem(current.Row + 1, current.Col, current.Word + boggleMatrix[current.Row + 1, current.Col]) { Visited = tempVisited });
                           
                        }

                        //Left
                        if (current.Col - 1 >= 0 && !current.Visited[current.Row, current.Col - 1])
                        {
                            var tempVisited = CopyVisitedNode(current.Visited);
                            queue.Enqueue(new BoggleItem(current.Row, current.Col - 1, current.Word + boggleMatrix[current.Row , current.Col - 1]) { Visited = tempVisited });

                        }

                        //Right
                        if (current.Col + 1 < colMax && !current.Visited[current.Row, current.Col + 1])
                        {
                            var tempVisited = CopyVisitedNode(current.Visited);
                            queue.Enqueue(new BoggleItem(current.Row, current.Col + 1, current.Word + boggleMatrix[current.Row, current.Col + 1]) { Visited = tempVisited });
                           
                        }

                        //Left diagonal Up
                        if (current.Row - 1 >= 0 && current.Col - 1 >= 0 && !current.Visited[current.Row - 1, current.Col - 1])
                        {
                            var tempVisited = CopyVisitedNode(current.Visited);
                            queue.Enqueue(new BoggleItem(current.Row - 1, current.Col - 1, current.Word + boggleMatrix[current.Row - 1, current.Col - 1]) { Visited = tempVisited });

                        }

                        //Left diagonal Down
                        if (current.Row + 1 < rowMax && current.Col - 1 >= 0 && !current.Visited[current.Row + 1, current.Col - 1])
                        {
                            var tempVisited = CopyVisitedNode(current.Visited);
                            queue.Enqueue(new BoggleItem(current.Row + 1, current.Col - 1, current.Word + boggleMatrix[current.Row + 1, current.Col - 1]) { Visited = tempVisited });

                        }

                        //Right Diagonal Up
                        if (current.Row - 1 >= 0 && current.Col + 1 < colMax && !current.Visited[current.Row - 1, current.Col + 1])
                        {
                            var tempVisited = CopyVisitedNode(current.Visited);
                            queue.Enqueue(new BoggleItem(current.Row - 1, current.Col + 1, current.Word + boggleMatrix[current.Row - 1, current.Col + 1] ) { Visited = tempVisited });

                        }

                        //Right Diagonal Down
                        if (current.Col + 1 < colMax && current.Row + 1 < rowMax && !current.Visited[current.Row + 1, current.Col + 1])
                        {
                            var tempVisited = CopyVisitedNode(current.Visited);
                            queue.Enqueue(new BoggleItem(current.Row + 1, current.Col + 1, current.Word + boggleMatrix[current.Row + 1, current.Col + 1]) { Visited = tempVisited });

                        }

                    }
                }
            }

            string printResult = "";
            foreach(var res in result) {
                printerOutput.Append(res + ", ");
            }
            if(printerOutput.Length > 2) {
                printResult = printerOutput.ToString().Substring(0, printerOutput.Length - 2);
            }
            return printResult;
        }
    }
}
