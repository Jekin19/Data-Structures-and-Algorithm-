using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRust.BinaryTrees
{
    public class PostOrderTraversal
    {
        public static void PostOrder<T>(BinaryTreeNode<T> root)
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
                var currentNode = stack.Peek();

                if(currentNode.Left == null && currentNode.Right == null)
                {
                    sb.Append(currentNode.Value + "=> ");
                    stack.Pop();
                }

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
            Console.WriteLine(sb.ToString().Substring(0, sb.Length-3));
        }

        public static void PostOrderRecursively<T>(BinaryTreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }

            PostOrderRecursively(root.Left);
            PostOrderRecursively(root.Right);
            Console.Write(root.Value + "  ");
        }
    }
}
