namespace CodeRust.BinaryTrees
{
    public static class BinaryTreeCreator
    {
        public static BinaryTree<int> GetBinaryTree()
        {
            BinaryTree<int> btree = new BinaryTree<int>();
            btree.Root = new BinaryTreeNode<int>(1);
            btree.Root.Left = new BinaryTreeNode<int>(2);
            btree.Root.Right = new BinaryTreeNode<int>(3);

            btree.Root.Left.Left = new BinaryTreeNode<int>(4);
            btree.Root.Right.Right = new BinaryTreeNode<int>(5);

            btree.Root.Left.Left.Right = new BinaryTreeNode<int>(6);
            btree.Root.Right.Right.Right = new BinaryTreeNode<int>(7);

            btree.Root.Right.Right.Right.Right = new BinaryTreeNode<int>(8);
            return btree;
        }

        public static BinaryTree<int> GetBinaryTree2()
        {
            BinaryTree<int> btree = new BinaryTree<int>();
            btree.Root = new BinaryTreeNode<int>(1);
            btree.Root.Left = new BinaryTreeNode<int>(2);
            btree.Root.Right = new BinaryTreeNode<int>(3);

            btree.Root.Left.Left = new BinaryTreeNode<int>(4);
            btree.Root.Right.Right = new BinaryTreeNode<int>(5);

            btree.Root.Left.Left.Right = new BinaryTreeNode<int>(6);
            btree.Root.Right.Right.Right = new BinaryTreeNode<int>(7);

            btree.Root.Left.Right = new BinaryTreeNode<int>(12);
            btree.Root.Left.Right.Right = new BinaryTreeNode<int>(112);

            //btree.Root.Right.Right.Right.Right = new BinaryTreeNode<int>(8);
            return btree;
        }

        public static BinaryTree<int> GetBinarySearchTree()
        {
            BinaryTree<int> btree = new BinaryTree<int>();
            btree.Root = new BinaryTreeNode<int>(100);
            btree.Root.Left = new BinaryTreeNode<int>(50);
            btree.Root.Right = new BinaryTreeNode<int>(150);

            btree.Root.Left.Left = new BinaryTreeNode<int>(25);
            btree.Root.Left.Right = new BinaryTreeNode<int>(75);


            //btree.Root.Right.Right.Right.Right = new BinaryTreeNode<int>(8);
            return btree;
        }
    }
}
