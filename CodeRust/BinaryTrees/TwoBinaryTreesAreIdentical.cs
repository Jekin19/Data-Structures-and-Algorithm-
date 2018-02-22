using System;
using System.Collections.Generic;

namespace CodeRust.BinaryTrees
{
    public class TwoBinaryTreesAreIdentical
    {
        public static void AreIdentical<T>(BinaryTreeNode<T> root1, BinaryTreeNode<T> root2)
        {
            if (root1 == null || root2 == null)
            { 
                Console.WriteLine("False");
                return;
            }

            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(root1);
            queue.Enqueue(root2);

            while(queue.Count> 0)
            {
                var currentRoot1 = queue.Dequeue();
                var currentRoot2 = queue.Dequeue();
                if(!currentRoot1.Value.Equals(currentRoot2.Value))
                {
                    Console.WriteLine("False");
                    return;
                }

                if (currentRoot1.Right != null && currentRoot2.Right != null)
                {
                    queue.Enqueue(currentRoot1.Right);
                    queue.Enqueue(currentRoot2.Right);
                }
                else if (currentRoot1.Right == null && currentRoot2.Right != null || currentRoot1.Right != null && currentRoot2.Right == null)
                {
                    Console.WriteLine("False");
                    return;
                }

                if (currentRoot1.Left != null && currentRoot2.Left != null)
                {
                    queue.Enqueue(currentRoot1.Left);
                    queue.Enqueue(currentRoot2.Left);
                }
                else if (currentRoot1.Left == null && currentRoot2.Left != null || currentRoot1.Left != null && currentRoot2.Left == null)
                {
                    Console.WriteLine("False");
                    return;
                }

            }
            Console.WriteLine("True");
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
