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
            Console.WriteLine("Inputs:");
            input = BinaryTreeCreator.GetBinaryTree().Root;
            input.Print();
            var input2 = BinaryTreeCreator.GetBinaryTree2().Root;
            input2.Print();
            TwoBinaryTreesAreIdentical.AreIdentical(input, input2);

            input = BinaryTreeCreator.GetBinaryTree().Root;
            input.Print();
            input2 = BinaryTreeCreator.GetBinaryTree2().Root;
            input2.Print();
            Console.WriteLine(TwoBinaryTreesAreIdentical.AreIdenticalRecursive(input, input2).ToString());


        }
    }
}
