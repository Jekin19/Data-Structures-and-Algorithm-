using System.Collections.Generic;
using System.Text;

namespace CodeRust.BackTracking
{
    public class ParenthesisItem {
        private StringBuilder sb = new StringBuilder();

        public string Output { get { return sb.ToString(); }}
        public int OpenCount { get; private set; }
        public int CloseCount { get { return Output.Length - OpenCount; } }
        public int Count { get { return Output.Length; }}

        public void AddOpen(ParenthesisItem item) {
            sb = new StringBuilder(item.Output);
            sb.Append('(');
            OpenCount = item.OpenCount + 1;
        }

        public void AddClose(ParenthesisItem item)
        {
            sb = new StringBuilder(item.Output);
            OpenCount = item.OpenCount;
            sb.Append(')');
        }
    }

    public class Parenthesis
    {
        public static string GetParenthesis(int n) {
            var result = new List<string>();
            if (n < 1) { return null; }

            Queue<ParenthesisItem> queue = new Queue<ParenthesisItem>();
            var currentItem = new ParenthesisItem();
            currentItem.AddOpen(currentItem);
            queue.Enqueue(currentItem);
            while(queue.Count > 0) {
                var current = queue.Dequeue();
                if (current.Count == 2*n) {
                    result.Add(current.Output);
                    continue;
                }

                if(current.OpenCount < n) {
                    var tempItem = new ParenthesisItem();
                    tempItem.AddOpen(current);
                    queue.Enqueue(tempItem);
                }
                if(current.CloseCount < current.OpenCount) {
                    var tempItem = new ParenthesisItem();
                    tempItem.AddClose(current);
                    queue.Enqueue(tempItem);
                }
            }
            var sb = new StringBuilder();
            result.ForEach(res => sb.Append(res + ", "));
            return sb.Length > 2 ? sb.ToString().Substring(0, sb.Length -2) : sb.ToString();
        }
    }
}
