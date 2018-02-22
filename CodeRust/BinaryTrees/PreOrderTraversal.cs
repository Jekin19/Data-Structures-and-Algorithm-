using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRust.BinaryTrees
{
    public static class PreOrderTraversal
    {
        public static void PreOrder<T>(BinaryTreeNode<T> root)
        {
            StringBuilder sb = new StringBuilder();
            if (root == null)
            {
                sb.AppendLine("Invalid Input");
            }

            Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var currentNode = stack.Pop();
                sb.Append(currentNode.Value + "=> ");

                if (currentNode.Right != null)
                {
                    stack.Push(currentNode.Right);
                    currentNode.Right = null;
                }
                if (currentNode.Left != null)
                {
                    stack.Push(currentNode.Left);
                    currentNode.Left = null;
                }
            }
            Console.WriteLine(sb.ToString().Substring(0, sb.Length - 3));
        }

        public static void PreOrderRecursively<T>(BinaryTreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }

            Console.Write(root.Value + "  ");
            PreOrderRecursively(root.Left);
            PreOrderRecursively(root.Right);
        }
    }
}
