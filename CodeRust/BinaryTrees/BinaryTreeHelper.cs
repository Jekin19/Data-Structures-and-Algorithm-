using System;
using CodeRust.Helpers;

namespace CodeRust.BinaryTrees
{
    public class BinaryTreeHelper
    {
        public static void BinaryTreeProblems()
        {

            // In Order Traversal
            var input = BinaryTreeCreator.GetBinaryTree().Root;
            PrintHelpers.PrintBinaryTree("InOrder Traversal Recursive", input, (x) => InOrderTraversal.InOrderRecursive(x));

            input = BinaryTreeCreator.GetBinaryTree().Root;
            PrintHelpers.PrintBinaryTree("InOrder Traversal", input, (x) => InOrderTraversal.InOrder(x));

            // Pre Order Traversal
            input = BinaryTreeCreator.GetBinaryTree().Root;
            PrintHelpers.PrintBinaryTree("PreOrder Traversal Recursive", input, (x) => PreOrderTraversal.PreOrderRecursively(x));

            input = BinaryTreeCreator.GetBinaryTree().Root;
            PrintHelpers.PrintBinaryTree("PreOrder Traversal", input, (x) => PreOrderTraversal.PreOrder(x));

            // Post Order Traversal
            input = BinaryTreeCreator.GetBinaryTree().Root;
            PrintHelpers.PrintBinaryTree("PostOrder Traversal Recursive", input, (x) => PostOrderTraversal.PostOrderRecursively(x));

            input = BinaryTreeCreator.GetBinaryTree().Root;
            PrintHelpers.PrintBinaryTree("PostOrder Traversal", input, (x) => PostOrderTraversal.PostOrder(x));

            // Are Identical?
            Console.WriteLine("Are Binary Tree Identical:");
            Console.WriteLine("Inputs:");
            input = BinaryTreeCreator.GetBinaryTree().Root;
            input.Print();
            var input2 = BinaryTreeCreator.GetBinaryTree().Root;
            input2.Print();
            Console.WriteLine(TwoBinaryTreesAreIdentical.AreIdentical(input, input2).ToString());

            input = BinaryTreeCreator.GetBinaryTree().Root;
            input.Print();
            input2 = BinaryTreeCreator.GetBinaryTree2().Root;
            input2.Print();
            Console.WriteLine(TwoBinaryTreesAreIdentical.AreIdenticalRecursive(input, input2).ToString().ToString());

            // In Order Successor
            input = BinaryTreeCreator.GetBinarySearchTree().Root;
            PrintHelpers.PrintBinaryTree("InOrder Successor of 75", input, x => InOrderSuccessor.FindInOrderSuccesor(x, 75));
            PrintHelpers.PrintBinaryTree("InOrder Successor Rec of 75", input, x => InOrderSuccessor.FindInOrderSuccesorRec(x, 75, new[]{false}));

            input = BinaryTreeCreator.GetBinaryTree().Root;
            PrintHelpers.PrintBinaryTree("Level Order Traversal:", input, (x) => LevelOrderTraversal.LevelOrder(x));

            input = BinaryTreeCreator.GetBinarySearchTree().Root;
            PrintHelpers.PrintBinaryTree("Is Binary Search Tree Recursivley:", input, null);
            Console.WriteLine(BinarySearchTree.IsBinarySearchTreeRecursive(input).ToString());

            PrintHelpers.PrintBinaryTree("Is Binary Search Tree:", input, null);
            Console.WriteLine(BinarySearchTree.IsBinarySearchTree(input).ToString());

            input = BinaryTreeCreator.GetBinaryTree().Root;
            PrintHelpers.PrintBinaryTree("Convert to doubly linked list:", input, (x) => ConvertToDoublyLinkedList.ToDoublyLinkedList(x));

            PrintHelpers.PrintBinaryTree("Print Tree Perimeter:", input, (x) => TreePerimeter.PrintTreePerimeter(x));

            PrintHelpers.PrintBinaryTree("Connect same level nodes:", input, (x) => ConnectSameLevelNodes.LevelOrder(x));

            input = BinaryTreeCreator.GetBinarySearchTree().Root;
            PrintHelpers.PrintBinaryTree("Nth Highest:", input, (x) => NthHighestInBinaryTree.NthHighest(x, 3));
            PrintHelpers.PrintBinaryTree("Nth Highest Rec:", input, (x) => NthHighestInBinaryTree.NthHighestRec(x, 3, new Count()));

            input = BinaryTreeCreator.GetBinaryTree3().Root;
            PrintHelpers.PrintBinaryTree("Delete Zero Sub Trees:", input, (x) => DeleteZeroSubTrees.DeleteZeroTrees(x));

            input = BinaryTreeCreator.GetBinaryTree().Root;
            PrintHelpers.PrintBinaryTree("Mirror Binary Tree:", input, (x) => MirrorBinaryTree.Mirror(x));
            input = BinaryTreeCreator.GetBinaryTree().Root;
            PrintHelpers.PrintBinaryTree("Mirror Binary Tree Rec:", input, (x) => MirrorBinaryTree.MirrorRec(x));

        }
    }
}
