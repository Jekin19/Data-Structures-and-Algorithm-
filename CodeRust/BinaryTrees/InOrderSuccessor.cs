using System;
using System.Collections.Generic;

namespace CodeRust.BinaryTrees
{
    public class InOrderSuccessor
    {
        public static T FindInOrderSuccesor<T>(BinaryTreeNode<T> root, T data)
        {
            if(root == null) {
                throw new Exception("Invalid Input");
            }
            Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();
            stack.Push(root);
            bool previous = false;
            while(stack.Count > 0) {
                var current = stack.Peek();
                if (current.Left != null) {
                    stack.Push(current.Left);
                    current.Left = null;
                } else {
                    current = stack.Pop();
                    if (previous) {
                        Console.WriteLine(current.Value);
                        return current.Value;
                    }
                    if(current.Value.Equals(data)) {
                        previous = true;
                    }
                    if (current.Right != null)
                    {
                        stack.Push(current.Right);
                        current.Right = null;
                    }
                }
            }

            return default(T);

        }

        public static void FindInOrderSuccesorRec<T>(BinaryTreeNode<T> root, T data, bool[] print)
        {
            if (root == null)
            {
                return;
            }
            if(print[0]) {
                Console.WriteLine(root.Value);
            }

            FindInOrderSuccesorRec(root.Left, data, print);
            if(root.Value.Equals(data)) {
                print[0] = true;
            }
            FindInOrderSuccesorRec(root.Right, data, print);

        }
    }
}
