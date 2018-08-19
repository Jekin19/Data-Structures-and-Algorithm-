using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRust.BinaryTrees
{
    public class ConvertToDoublyLinkedList
    {
        public static void ToDoublyLinkedList<T>(BinaryTreeNode<T> root)
        {
            if (root == null)
            {
                throw new Exception("Invalid input");
            }
            Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();
          
            stack.Push(root);
            BinaryTreeNode<T> previous = null;
            while (stack.Count > 0)
            {
                var currentNode = stack.Peek();
                if (currentNode.Left != null)
                {
                    stack.Push(currentNode.Left);
                    currentNode.Left = null;
                }
                else
                {
                    
                    if(previous == null) {
                        previous = currentNode;
                    } else {
                        previous.Right = currentNode;
                        currentNode.Left = previous;
                        previous = currentNode;
                    }
                    stack.Pop();
                    if (currentNode.Right != null)
                    {
                        stack.Push(currentNode.Right);
                        currentNode.Right = null;
                    }
                }
            }

            StringBuilder sb = new StringBuilder();
            while(previous.Left != null) {
                sb.Append(previous.Value + "=> ");
                previous = previous.Left;
            }
            Console.WriteLine(sb.ToString().Substring(0, sb.Length - 3));

            sb = new StringBuilder();
            while (previous != null)
            {
                sb.Append(previous.Value + "=> ");
                previous = previous.Right;
            }
            Console.WriteLine(sb.ToString().Substring(0, sb.Length - 3));
         
        }
    }
}
