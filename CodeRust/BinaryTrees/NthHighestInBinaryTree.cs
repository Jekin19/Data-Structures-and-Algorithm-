using System;
namespace CodeRust.BinaryTrees
{
    public class Count
    {
       public int c = 0;
    }

    public class NthHighestInBinaryTree
    {
        public static void NthHighest<T>(BinaryTreeNode<T> root, int k, Count c) {
            if (root == null || c.c > k) {
                return;
            }

            NthHighest(root.Right, k, c);
            c.c++;
            if (k == c.c) {
                Console.WriteLine(root.Value);
            }
            NthHighest(root.Left, k, c);
            
        }
    }
}
