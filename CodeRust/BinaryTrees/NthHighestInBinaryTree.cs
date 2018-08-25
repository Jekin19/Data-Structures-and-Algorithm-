using System;
using System.Collections.Generic;
namespace CodeRust.BinaryTrees
{
    public class Count
    {
       public int c = 0;
    }

    public class NthHighestInBinaryTree
    {
        public static void NthHighest<T>(BinaryTreeNode<T> root, int n)
        {
            if (root == null) { return; }

            Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();
            stack.Push(root);
            int count = 0;
            while (stack.Count > 0)
            {
                var current = stack.Peek();
                if (current.Right != null)
                {
                    stack.Push(current.Right);
                    current.Right = null;
                }
                else
                {
                    current = stack.Pop();
                    count++;
                    if (n == count)
                    {
                        Console.WriteLine(current.Value);
                        return;
                    }
                    if (current.Left != null)
                    {
                        stack.Push(current.Left);
                        current.Left = null;
                    }
                }

            }
        }

        public static void NthHighestRec<T>(BinaryTreeNode<T> root, int n, Count count)
        {
            if (root == null) { return; }

            NthHighestRec(root.Right, n, count);
            count.c++;
            if (count.c == n) {
                Console.WriteLine(root.Value);
                return;
            }
            NthHighestRec(root.Left, n, count);
        }
    }
}
