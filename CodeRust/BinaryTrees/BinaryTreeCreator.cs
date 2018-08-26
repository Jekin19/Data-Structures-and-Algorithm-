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

        public static BinaryTree<int> GetBinaryTree3()
        {
            BinaryTree<int> btree = new BinaryTree<int>();
            btree.Root = new BinaryTreeNode<int>(7);
            btree.Root.Left = new BinaryTreeNode<int>(5);
            btree.Root.Right = new BinaryTreeNode<int>(6);

            btree.Root.Left.Left = new BinaryTreeNode<int>(-3);
            btree.Root.Left.Right = new BinaryTreeNode<int>(-2);
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

        public static BinaryTree<int> GetBinarySearchTreeWithPointers()
        {
            BinaryTree<int> btree = new BinaryTree<int>();
            btree.Root = new BinaryTreeNodeWithAddPointers<int>(100);
            btree.Root.Left = new BinaryTreeNodeWithAddPointers<int>(50);
            btree.Root.Right = new BinaryTreeNodeWithAddPointers<int>(150);

            btree.Root.Left.Left = new BinaryTreeNodeWithAddPointers<int>(25);
            btree.Root.Left.Right = new BinaryTreeNodeWithAddPointers<int>(75);


            //btree.Root.Right.Right.Right.Right = new BinaryTreeNode<int>(8);
            return btree;
        }

        public static Tree<int> GetTree()
        {
            Tree<int> tree = new Tree<int>();
            tree.Root = new Node<int>(1);
            var node = new Node<int>(3);
            node.Neighbors = new NodeList<int> { new Node<int>(5), new Node<int>(6) };
            tree.Root.Neighbors = new NodeList<int> { new Node<int>(2), node, new Node<int>(4) };

            return tree;
        }
    }
}
