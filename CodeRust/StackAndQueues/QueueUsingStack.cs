using System.Collections.Generic;

namespace CodeRust.StackAndQueues
{
    public class QueueUsingStack<T>
    {
        public Stack<T> stack1 = new Stack<T>();
        public Stack<T> stack2 = new Stack<T>();

        public int Count
        {
            get
            {
                return stack1.Count;
            }
        }

        public T Peek()
        {
            if (stack1.Count > 0)
            {
                return stack1.Peek();
            }
            return default(T);
        }

        public void Clear()
        {
            stack1 = new Stack<T>();
        }

        public void Enqueue(T input)
        {
            stack1.Push(input);
        }

        public T Dequeue()
        {
            var result = default(T);
            while (stack1.Count > 1)
            {
                stack2.Push(stack1.Pop());
            }
            if (stack1.Count > 0)
            {
                result = stack1.Pop();
            }
            Swap();

            return result;
        }

        private void Swap(){
            Stack<T> temp = stack1;
            stack1 = stack2;
            stack2 = temp;
        }

    }
}
