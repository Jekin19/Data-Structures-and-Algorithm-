using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRust.BinaryTrees
{
    public class TreePerimeter
    {
        public static void PrintTreePerimeter<T>(BinaryTreeNode<T> root)
        {
            var leftRoot = root;
            PrintLeftPerimeter(root);
            PrintLeafNodes(leftRoot);
            Console.WriteLine();
            PrintRightPerimeter(leftRoot);
        }

        private static void PrintLeftPerimeter<T>(BinaryTreeNode<T> root) {
            if (root == null) {
                return;
            }
            StringBuilder sb = new StringBuilder();
            while(root!= null) {
                if (root.Left!=null) {
                    sb.Append(root.Value + "=> ");
                    root = root.Left;
                } else if (root.Right != null)
                {
                    sb.Append(root.Value + "=> ");
                    root = root.Right;
                } else {
                    break;
                }

            }
            Console.WriteLine(sb.ToString().Substring(0, sb.Length - 3));
        }

        private static void PrintLeafNodes<T>(BinaryTreeNode<T> root)
        {
            if(root == null) {
                return;
            }

            if(root.Left == null && root.Right == null) {
                Console.Write(root.Value + "=> ");
            }

            PrintLeafNodes(root.Left);
            PrintLeafNodes(root.Right);
        }

        private static void PrintRightPerimeter<T>(BinaryTreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }
            Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();
            while (root != null)
            {
               
                if (root.Right != null)
                {
                    stack.Push(root);
                    root = root.Right;
                }
                else if (root.Left != null)
                {
                    stack.Push(root);
                    root = root.Left;
                }
                else
                {
                    break;
                }

            }

            StringBuilder sb = new StringBuilder();
            while(stack.Count>0) {
                sb.Append(stack.Pop().Value + "=> ");
            }
            Console.WriteLine(sb.ToString().Substring(0, sb.Length - 3));
        }

    }
}
