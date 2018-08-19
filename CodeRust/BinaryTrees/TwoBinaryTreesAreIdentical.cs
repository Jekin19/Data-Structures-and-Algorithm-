using System;
using System.Collections.Generic;

namespace CodeRust.BinaryTrees
{
    public class TwoBinaryTreesAreIdentical
    {
        public static bool AreIdentical<T>(BinaryTreeNode<T> rootFirst, BinaryTreeNode<T> rootSecond)
        {
            if(rootFirst == null || rootSecond == null) {
                return false;
            }
            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(rootFirst);
            queue.Enqueue(rootSecond);

            while(queue.Count> 0) {
                var root1 = queue.Dequeue();
                var root2 = queue.Dequeue();

                if(!root1.Value.Equals(root2.Value)) {
                    return false; 
                }    
                if(root1.Left != null && root2.Left != null) {
                    queue.Enqueue(root1.Left);
                    queue.Enqueue(root2.Left);
                }
                if (root1.Right != null && root2.Right != null)
                {
                    queue.Enqueue(root1.Right);
                    queue.Enqueue(root2.Right);
                }
                if((root1.Left == null && root2.Left != null) || (root1.Left != null && root2.Left == null)) {
                    return false;
                }
                if ((root1.Right == null && root2.Right != null) || (root1.Right != null && root2.Right == null))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AreIdenticalRecursive<T>(BinaryTreeNode<T> root1, BinaryTreeNode<T> root2)
        {
            if(root1 == null && root2 == null)
            {
                return true;
            }

            if (root1 != null && root2 != null)
            {
                return (root2.Value.Equals(root1.Value) &&
                    AreIdenticalRecursive(root1.Left, root2.Left) && AreIdenticalRecursive(root1.Right, root2.Right));
            }

            return false;
        }
    }
}
