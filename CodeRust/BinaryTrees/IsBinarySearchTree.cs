using System;
using System.Collections.Generic;

namespace CodeRust.BinaryTrees
{
    public class BinarySearchTree
    {
        public static bool IsBinarySearchTree(BinaryTreeNode<int> root) {
            if (root == null) {
                return true;
            }
            Stack<BinaryTreeNode<int>> stack = new Stack<BinaryTreeNode<int>>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var currentNode = stack.Pop();

                if (currentNode.Right != null)
                {
                    if (currentNode.Right.Value < currentNode.Value) {
                        return false;
                    }
                    stack.Push(currentNode.Right);
                    currentNode.Right = null;
                }
                if (currentNode.Left != null)
                {
                    if (currentNode.Left.Value > currentNode.Value)
                    {
                        return false;
                    }
                    stack.Push(currentNode.Left);
                    currentNode.Left = null;
                }
            }


            return true;
        }

        public static bool IsBinarySearchTreeRecursive(BinaryTreeNode<int> root)
        {
           return BinarySearchTreeRecursively(root, Int32.MinValue, Int32.MaxValue);

        }

        private static bool BinarySearchTreeRecursively(BinaryTreeNode<int> root, int min, int max) {
            if (root == null) {
                return true;
            }

            if(root.Value < min || root.Value > max) {
                return false;
            }

            return (BinarySearchTreeRecursively(root.Left, min, root.Value) && BinarySearchTreeRecursively(root.Right, root.Value, max));

        }       
    }
}
