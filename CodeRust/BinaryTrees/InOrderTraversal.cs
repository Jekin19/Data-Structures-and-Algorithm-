using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRust.BinaryTrees
{
    public class InOrderTraversal
    {
        public static void InOrder<T>( BinaryTreeNode<T> root)
        {
            if(root == null )
            {
                throw new Exception("Invalid input");
            }
            Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();
            StringBuilder sb = new StringBuilder();
            stack.Push(root);

            while(stack.Count>0)
            {
                var currentNode = stack.Peek();
                if(currentNode.Left != null)
                {
                    stack.Push(currentNode.Left);
                    currentNode.Left = null;
                }
                else
                {
                    sb.Append(currentNode.Value + "=> ");
                    stack.Pop();
                    if(currentNode.Right !=null)
                    {
                        stack.Push(currentNode.Right);
                        currentNode.Right = null;
                    }
                }
            }

            Console.WriteLine(sb.ToString().Substring(0, sb.Length-3));
        }

        public static void InOrderRecursive<T>(BinaryTreeNode<T> root)
        {
             if (root == null)
            {
                return;
            }

            InOrderRecursive(root.Left);
            Console.Write(root.Value + "  ");
            InOrderRecursive(root.Right);
        }
    }
}
