namespace CodeRust.BinaryTrees
{
    public class BinaryTree<T>
    {
        BinaryTreeNode<T> root;

        public BinaryTree()
        {
            root = null;
        }

        public virtual void Clear()
        {
            root = null;
        }

        public BinaryTreeNode<T> Root
        {
            get
            {
                return root;
            }
            set
            {
                root = value;
            }
        }
    }

    public class Tree<T> {
        Node<T> root;

        public Tree()
        {
            root = null;
        }

        public virtual void Clear()
        {
            root = null;
        }

        public Node<T> Root
        {
            get
            {
                return root;
            }
            set
            {
                root = value;
            }
        }
    }
}
