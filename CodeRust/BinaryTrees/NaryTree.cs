using System;
using System.Collections.Generic;

namespace CodeRust.BinaryTrees
{
    public class NaryTree
    {
        public static BinaryTreeNode<T> Encode<T>(Node<T> root) {
            if (root == null) { return null; }

            Queue<Node<T>> queue = new Queue<Node<T>>();
            Queue<BinaryTreeNode<T>> bQueue = new Queue<BinaryTreeNode<T>>();
            BinaryTreeNode<T> bRoot = new BinaryTreeNode<T>(root.Value);
            bQueue.Enqueue(bRoot);
            queue.Enqueue(root);

            while(queue.Count > 0) {
                var current = queue.Dequeue();
                var temp = bQueue.Dequeue();
                for (int i = 0; i < current.Neighbors.Count; i++) {
                    if (temp.Right != null) {
                        temp.Left = new BinaryTreeNode<T>(current.Neighbors[i].Value);
                        temp = temp.Left;
                    }
                    else
                    {
                        temp.Right = new BinaryTreeNode<T>(current.Neighbors[i].Value);
                        temp = temp.Right;
                    }
                    queue.Enqueue(current.Neighbors[i]);
                    bQueue.Enqueue(temp);
                }
             
            }

            Console.WriteLine("Output:");
            bRoot.Print();
            return bRoot;

        }

        public static void Decode<T>(BinaryTreeNode<T> root)
        {
            if (root == null) { return; }

            Queue<Node<T>> queue = new Queue<Node<T>>();
            Queue<BinaryTreeNode<T>> bQueue = new Queue<BinaryTreeNode<T>>();
            Node<T> node = new Node<T>(root.Value);
            bQueue.Enqueue(root);
            queue.Enqueue(node);

            while (bQueue.Count > 0)
            {
                var current = bQueue.Dequeue();
                var currentNode = queue.Dequeue();
                if (current.Right != null)
                {
                    var temp = current.Right;
                    var previous = current;
                    currentNode.Neighbors = new NodeList<T>(3);
                    int count = 0;
                    while (temp != null && temp.Neighbors!=null && temp.Neighbors.Count > 0) 
                    {
                        var tempNode = new Node<T>(temp.Value);
                        currentNode.Neighbors[count] = tempNode;
                        count++;
                        bQueue.Enqueue(temp);
                        queue.Enqueue(tempNode);
                        previous = temp;
                        temp = temp.Right;
                        previous.Right = null;
                    }
                }
                else
                {
                    var temp = current.Left;
                    var previous = current;
                    currentNode.Neighbors = new NodeList<T>(3);
                    int count = 0;
                    while (temp != null && temp.Neighbors != null && temp.Neighbors.Count > 0)
                    {
                        var tempNode = new Node<T>(temp.Value);
                        currentNode.Neighbors[count] = tempNode;
                        count++;
                        bQueue.Enqueue(temp);
                        queue.Enqueue(tempNode);
                        previous = temp;
                        temp = temp.Left;
                        previous.Left = null;
                    }
                }
            
            }

            Console.WriteLine("Output:");
      

        }
    }
}
