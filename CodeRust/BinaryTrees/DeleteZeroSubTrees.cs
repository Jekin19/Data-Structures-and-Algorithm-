using System;
namespace CodeRust.BinaryTrees
{
    public class DeleteZeroSubTrees
    {
        public static void DeleteZeroTrees(BinaryTreeNode<int> root)
        {

            if (root == null)
            {
                return;
            }

            if(0 == DeleteZeroTreesRec(root)) {
                root = null;
            }
            Console.WriteLine("Output: ");
            root.Print();
            return;
        }

        public static int DeleteZeroTreesRec(BinaryTreeNode<int> root)
        {
            if (root == null)
            {
                return 0;
            }

            int left = DeleteZeroTreesRec(root.Left);
            if (left == 0) {
                root.Left = null;
            }

            int right = DeleteZeroTreesRec(root.Right);
            if (right == 0)
            {
                root.Right = null;
            }

            return root.Value + left + right;
        }
    }
}
