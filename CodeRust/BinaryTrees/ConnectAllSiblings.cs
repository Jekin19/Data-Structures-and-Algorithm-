using System;
using System.Collections.Generic;

namespace CodeRust.BinaryTrees
{
    public class ConnectAllSiblings
    {
        public static void ConnectAll<T>(BinaryTreeNodeWithAddPointers<T> root) {
            if(root == null) {
                return;
            }

            Queue<BinaryTreeNodeWithAddPointers<T>> queue = new Queue<BinaryTreeNodeWithAddPointers<T>>();
            queue.Enqueue(root);
            BinaryTreeNodeWithAddPointers<T> previous = null;
            while (queue.Count > 0) {
                var current = queue.Dequeue();
                if (previous != null) {
                    previous.Next = current;
                } 
                previous = current;

                if(current.Left != null) {
                    queue.Enqueue((BinaryTreeNodeWithAddPointers<T>)current.Left);
                }
                if (current.Right != null)
                {
                    queue.Enqueue((BinaryTreeNodeWithAddPointers<T>)current.Right);
                }

            }

            if (root == null)
                return;

            //var current = root;
            //var last = root;

            //while (current != null)
            //{
            //    if (current.left != null)
            //    {
            //        last.next = current.left;
            //        last = current.left;
            //    }

            //    if (current.right != null)
            //    {
            //        last.next = current.right;
            //        last = current.right;
            //    }

            //    last.next = null;
            //    current = current.next;
            //}
            Console.WriteLine("Output: ");
            root.Print();
        }
    }
}
