using System;
using System.Collections.Generic;

namespace CodeRust.BinaryTrees
{
    public class LevelOrderTraversal
    {
        public static void LevelOrder<T>(BinaryTreeNode<T> root)
        {
            if (root == null) {
                return;
            }
            Queue<BinaryTreeNode<T>> queue1 = new Queue<BinaryTreeNode<T>>();
            Queue<BinaryTreeNode<T>> queue2 = new Queue<BinaryTreeNode<T>>();
            queue2.Enqueue(root);
            while (queue2.Count > 0)
            {
                while (queue2.Count > 0)
                {
                    queue1.Enqueue(queue2.Dequeue());
                }
                Console.WriteLine("");
                while (queue1.Count > 0)
                {
                    var current = queue1.Dequeue();
                    Console.Write(current.Value + " ");
                    if (current.Left != null)
                    {
                        queue2.Enqueue(current.Left);
                    }
                    if (current.Right != null)
                    {
                        queue2.Enqueue(current.Right);
                    }
                }
            }
        }
    }
}
