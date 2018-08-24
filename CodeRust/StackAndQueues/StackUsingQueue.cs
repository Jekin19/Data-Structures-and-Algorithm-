using System.Collections.Generic;

namespace CodeRust.StackAndQueues
{
    public class StackUsingQueue<T>
    {
        public Queue<T> queue1 = new Queue<T>();
        public Queue<T> queue2 = new Queue<T>();

        public int Count {
            get {
                return queue1.Count;
            }
        }

        public T Peek() {
            if(queue1.Count > 0) {
                return queue1.Peek();
            }
            return default(T);
        }

        public void Clear() {
            queue1 = new Queue<T>();
        }

        public void Push(T input) {
            queue1.Enqueue(input);
        }

        public T Pop(){
            var result = default(T);
            while(queue1.Count > 1) {
                queue2.Enqueue(queue1.Dequeue());
            }
            if (queue1.Count > 0) {
                result = queue1.Dequeue();
            }
            while (queue2.Count > 0)
            {
                queue1.Enqueue(queue2.Dequeue());
            }

            return result;
        }

    }
}
