using System.Collections.Generic;

namespace CodeRust.StackAndQueues
{
    public class StackUsingQueue<T>
    {
        Queue<T> queue1 = new Queue<T>();
        Queue<T> queue2 = new Queue<T>();

        public int Count { get { return queue1.Count; }}

        public void Clear() {
            queue1.Clear();
        }

        public void Push(T item) {
            queue1.Enqueue(item);
        }

        public T Peek() {
            return queue1.Peek();
        }

        public T Pop() {
            while(queue1.Count > 1) {
                queue2.Enqueue(queue1.Dequeue());
            }
            var result = queue1.Dequeue();
            var temp = queue1;
            queue1 = queue2;
            queue2 = temp;
            return result;
        }

    }
}
