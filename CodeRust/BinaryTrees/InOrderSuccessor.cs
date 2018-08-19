using System;
using System.Collections.Generic;

namespace CodeRust.BinaryTrees
{
    public class InOrderSuccessor
    {
        public static T FindInOrderSuccesor<T>(BinaryTreeNode<T> root, T data)
        {
            if (root == null)
            {
                throw new Exception("Invalid input");
            }
            Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();
            stack.Push(root);
            BinaryTreeNode<T> previous = root;;

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
                    if (data.Equals(currentNode.Value)) {
                        return previous.Value;
                    }
                    previous = stack.Pop();
                    if (currentNode.Right != null)
                    {
                        stack.Push(currentNode.Right);
                        currentNode.Right = null;
                    }
                }
            }
            return default(T);

        }
    }
}
