using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRust.BinaryTrees
{
    public class ConnectSameLevelNodes
    {
        public static void LevelOrder<T>(BinaryTreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }
            Queue<BinaryTreeNode<T>> queue1 = new Queue<BinaryTreeNode<T>>();
            Queue<BinaryTreeNode<T>> queue2 = new Queue<BinaryTreeNode<T>>();
            Queue<BinaryTreeNode<T>> queue3 = new Queue<BinaryTreeNode<T>>();
            queue2.Enqueue(root);
            BinaryTreeNode<T> previous = null;
            while (queue2.Count > 0)
            {
                while (queue2.Count > 0)
                {
                    queue1.Enqueue(queue2.Dequeue());
                }
               
                previous = null;
                while (queue1.Count > 0)
                {
                    var current = queue1.Dequeue();
                    if (previous == null)
                    {
                        previous = current;
                        queue3.Enqueue(previous);
                    }
                    else {
                        previous.Right = current;
                        previous = current;
                    }
                    if (current.Left != null)
                    {
                        queue2.Enqueue(current.Left);
                    }
                    if (current.Right != null)
                    {
                        queue2.Enqueue(current.Right);
                    }
                    previous.Right = null;
                }
            }
           
            while(queue3.Count > 0 ){
                var curr = queue3.Dequeue();
                StringBuilder sb = new StringBuilder();
                while(curr != null) {
                    sb.Append(curr.Value + "=> ");
                    curr = curr.Right;
                }
                Console.WriteLine(sb.ToString().Substring(0, sb.Length - 3));
            }

        }
    }
}
