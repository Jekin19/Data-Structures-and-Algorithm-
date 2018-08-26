using System;
using CodeRust.BinaryTrees;
using System.Collections.Generic;

namespace CodeRust.Graphs
{
    public class Graph{

        public static void TestMethod() {
            var node0 = new Node<int>(0);
            var node1 = new Node<int>(1);
            var node2 = new Node<int>(2);
            var node3 = new Node<int>(3);
            var node4 = new Node<int>(4);
            node0.Neighbors.Add(node2);
            node0.Neighbors.Add(node3);
            node0.Neighbors.Add(node4);

            node2.Neighbors.Add(node0);

            node1.Neighbors.Add(node2);

            node3.Neighbors.Add(node2);

            node4.Neighbors.Add(node0);
            node4.Neighbors.Add(node1);
            node4.Neighbors.Add(node3);

            var result = Clone(node0);
        }

        public static Node<T> Clone<T>(Node<T> root) {
            if (root == null) {
                return null;
            }

            Queue<Node<T>> queue = new Queue<Node<T>>();
            Queue<Node<T>> clonedQueue = new Queue<Node<T>>();
            Dictionary<Node<T>, Node<T>> dict = new Dictionary<Node<T>, Node<T>>();
            HashSet<Node<T>> visitedNodeSet = new HashSet<Node<T>>();

            queue.Enqueue(root);
            var clonedRoot = new Node<T>(root.Value);
            clonedQueue.Enqueue(clonedRoot);
            dict.Add(root, clonedRoot);

            while (queue.Count >0) {
                // Dequeu from both queues
                var currentNode = queue.Dequeue();
                var clonedNode = clonedQueue.Dequeue();

                // If current node is not visited
                if (!visitedNodeSet.Contains(currentNode)) {
                    visitedNodeSet.Add(currentNode);
                    if(currentNode.Neighbors != null) {
                        foreach (var node in currentNode.Neighbors)
                        {
                            // If dictionary doesn't contain mapping node create new and add it
                            if (!dict.ContainsKey(node)) {
                                var tempNode = new Node<T>(node.Value);
                                dict.Add(node, tempNode);
                            }

                            // Add neighboor nodes to queue
                            clonedNode.Neighbors.Add(dict[node]);
                            queue.Enqueue(node);
                            clonedQueue.Enqueue(dict[node]);
                        }
                    }

                }

            }
            return clonedRoot;           
        }
    }

}
