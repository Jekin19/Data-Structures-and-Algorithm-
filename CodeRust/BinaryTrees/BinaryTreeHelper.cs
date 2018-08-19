using System;
using CodeRust.Helpers;

namespace CodeRust.BinaryTrees
{
    public class BinaryTreeHelper
    {
        public static void BinaryTreeProblems()
        {

            // In Order Traversal
            //var input = BinaryTreeCreator.GetBinaryTree().Root;
            //PrintHelpers.PrintBinaryTree("InOrder Traversal Recursive", input, (x) => InOrderTraversal.InOrderRecursive(x));

            //input = BinaryTreeCreator.GetBinaryTree().Root;
            //PrintHelpers.PrintBinaryTree("InOrder Traversal", input, (x) => InOrderTraversal.InOrder(x));

            //// Pre Order Traversal
            //input = BinaryTreeCreator.GetBinaryTree().Root;
            //PrintHelpers.PrintBinaryTree("PreOrder Traversal Recursive", input, (x) => PreOrderTraversal.PreOrderRecursively(x));

            //input = BinaryTreeCreator.GetBinaryTree().Root;
            //PrintHelpers.PrintBinaryTree("PreOrder Traversal", input, (x) => PreOrderTraversal.PreOrder(x));

            //// Post Order Traversal
            //input = BinaryTreeCreator.GetBinaryTree().Root;
            //PrintHelpers.PrintBinaryTree("PostOrder Traversal Recursive", input, (x) => PostOrderTraversal.PostOrderRecursively(x));

            //input = BinaryTreeCreator.GetBinaryTree().Root;
            //PrintHelpers.PrintBinaryTree("PostOrder Traversal", input, (x) => PostOrderTraversal.PostOrder(x));

            //// Are Identical?
            //Console.WriteLine("Are Binary Tree Identical:");
            //Console.WriteLine("Inputs:");
            //input = BinaryTreeCreator.GetBinaryTree().Root;
            //input.Print();
            //var input2 = BinaryTreeCreator.GetBinaryTree().Root;
            //input2.Print();
            //Console.WriteLine(TwoBinaryTreesAreIdentical.AreIdentical(input, input2).ToString());

            //input = BinaryTreeCreator.GetBinaryTree().Root;
            //input.Print();
            //input2 = BinaryTreeCreator.GetBinaryTree2().Root;
            //input2.Print();
            //Console.WriteLine(TwoBinaryTreesAreIdentical.AreIdenticalRecursive(input, input2).ToString().ToString());

            // In Order Successor
            //var input = BinaryTreeCreator.GetBinaryTree().Root;
            //PrintHelpers.PrintBinaryTree("InOrder Successor:", input, null);
            //Console.WriteLine(InOrderSuccessor.FindInOrderSuccesor(input, 5));

            //var input = BinaryTreeCreator.GetBinaryTree().Root;
            //PrintHelpers.PrintBinaryTree("Level Order Traversal:", input, (x) => LevelOrderTraversal.LevelOrder(x));

            var input = BinaryTreeCreator.GetBinarySearchTree().Root;
            //PrintHelpers.PrintBinaryTree("Is Binary Search Tree Recursivley:", input, null);
            //Console.WriteLine(BinarySearchTree.IsBinarySearchTreeRecursive(input).ToString());

            //PrintHelpers.PrintBinaryTree("Is Binary Search Tree:", input, null);
            //Console.WriteLine(BinarySearchTree.IsBinarySearchTree(input).ToString());

            PrintHelpers.PrintBinaryTree("Convert to doubly linked list:", input, (x) => ConvertToDoublyLinkedList.ToDoublyLinkedList(x));

        }
    }
}
