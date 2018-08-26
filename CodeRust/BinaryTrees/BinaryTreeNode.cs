namespace CodeRust.BinaryTrees
{
    public class BinaryTreeNode<T> : Node<T>
    {
        public BinaryTreeNode() { }
        public BinaryTreeNode(T data) : base(data, null) { }
        public BinaryTreeNode(T data, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            Value = data;
            NodeList<T> children = new NodeList<T>(2)
            {
                [0] = left,
                [1] = right
            };
            base.Neighbors = children;
        }

        public BinaryTreeNode<T> Left
        {
            get
            {
                if (base.Neighbors == null)
                    return null;
                else
                    return (BinaryTreeNode<T>)base.Neighbors[0];
            }
            set
            {
                if (base.Neighbors == null)
                    base.Neighbors = new NodeList<T>(2);

                base.Neighbors[0] = value;
            }
        }

        public BinaryTreeNode<T> Right
        {
            get
            {
                if (base.Neighbors == null)
                    return null;
                else
                    return (BinaryTreeNode<T>)base.Neighbors[1];
            }
            set
            {
                if (base.Neighbors == null)
                    base.Neighbors = new NodeList<T>(2);

                base.Neighbors[1] = value;
            }
        }
    }

    public class BinaryTreeNodeWithAddPointers<T> : BinaryTreeNode<T>
    {
        public BinaryTreeNodeWithAddPointers(T data)
        {
            Value = data;
            NodeList<T> children = new NodeList<T>(4)
            {
                [0] = Left,
                [1] = Right,
                [2] = Next
            };
            Neighbors = children;
        }

        public BinaryTreeNode<T> Next
        {
            get
            {
                if (base.Neighbors == null)
                    return null;
                else
                    return (BinaryTreeNode<T>)base.Neighbors[2];
            }
            set
            {
                if (base.Neighbors == null)
                    base.Neighbors = new NodeList<T>(3);

                base.Neighbors[2] = value;
            }
        }
    }

}
