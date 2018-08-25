using System;
using System.Collections.Generic;

namespace CodeRust.BinaryTrees
{
    public class MirrorBinaryTree
    {
        public static void Mirror(BinaryTreeNode<int> root) {
            if (root == null) { return; }

            Queue<BinaryTreeNode<int>> queue = new Queue<BinaryTreeNode<int>>();
            queue.Enqueue(root);
            while(queue.Count > 0) {
                var current = queue.Dequeue();
                var temp = current.Right;
                current.Right = current.Left;
                current.Left = temp;
                if (current.Left != null) {
                    queue.Enqueue(current.Left);
                }
                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }
            Console.WriteLine("Output:");
            root.Print();

        }

        public static void MirrorRec(BinaryTreeNode<int> root)
        {
            if (root == null) { return; }
            Mirror_Rec(root);
            Console.WriteLine("Output:");
            root.Print();

        }

        private static void Mirror_Rec(BinaryTreeNode<int> root) {
            if (root == null) { return; }
            if(root.Left != null) {
                Mirror_Rec(root.Left);
            }
            if (root.Right != null)
            {
                Mirror_Rec(root.Right);
            }
            var temp = root.Right;
            root.Right = root.Left;
            root.Left = temp;
        }
    }
}
