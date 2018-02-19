using System;
using CodeRust.Arrays;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using CodeRust.LinkedLists;
using CodeRust.Helpers;

namespace CodeRust
{
    class Program
    {
        static void Main()
        {

            //Arrays
            // ArrayHelpers.ArrayProblems();

            // Linked List

            // Reverse a linked list
            LinkedList<int> linked = new LinkedList<int>();
            linked.AddLast(1);
            linked.AddLast(2);
            linked.AddLast(3);
            LinkedList<int> linked2 = new LinkedList<int>();
            linked2.AddLast(1);
            linked2.AddLast(2);
            linked2.AddLast(3);
            PrintHelpers.PrintArray("Reverse Linked List", linked2.ToArray(), ReverseLinkedList.Reverse(linked).ToArray());


            // Remove duplicates in a linked list
            linked = new LinkedList<int>();
            linked.AddLast(1);
            linked.AddLast(2);
            linked.AddLast(2);
            linked.AddLast(3);
            linked2 = new LinkedList<int>();
            linked2.AddLast(1);
            linked2.AddLast(2);
            linked2.AddLast(2);
            linked2.AddLast(3);
            PrintHelpers.PrintArray("Remove Duplicates", linked2.ToArray(), RemoveDuplicates.RemoveDuplicate(linked).ToArray());

            // Remove duplicates in a Custom linked list
            var customLinked = new CustomLinkedList<int>();
            customLinked.Head = new Node<int>{Value = 1};
            customLinked.Head.Next = new Node<int> { Value = 2 };
            customLinked.Head.Next.Next = new Node<int> { Value = 2 };
            customLinked.Head.Next.Next.Next = new Node<int> { Value = 3 };
            var customLinked2 = new CustomLinkedList<int>();
            customLinked2.Head = new Node<int> { Value = 1 };
            customLinked2.Head.Next = new Node<int> { Value = 2 };
            customLinked2.Head.Next.Next = new Node<int> { Value = 2 };
            customLinked2.Head.Next.Next.Next = new Node<int> { Value = 3 };
            PrintHelpers.PrintArray("Remove Duplicates Custom Linked List", customLinked2, RemoveDuplicates.RemoveDuplicate(customLinked));


            // Remove Node with given key in a linked list
            linked = new LinkedList<int>();
            linked.AddLast(1);
            linked.AddLast(2);
            linked.AddLast(2);
            linked.AddLast(3);
            linked2 = new LinkedList<int>();
            linked2.AddLast(1);
            linked2.AddLast(2);
            linked2.AddLast(2);
            linked2.AddLast(3);
            PrintHelpers.PrintArray("Remove Node with given key ", linked2.ToArray(), RemoveNodeWithGivenKey.Remove(linked, 2).ToArray());

            // Remove Node with given key in a Custom linked list
            customLinked = new CustomLinkedList<int>();
            customLinked.Head = new Node<int> { Value = 1 };
            customLinked.Head.Next = new Node<int> { Value = 2 };
            customLinked.Head.Next.Next = new Node<int> { Value = 2 };
            customLinked.Head.Next.Next.Next = new Node<int> { Value = 3 };
            customLinked2 = new CustomLinkedList<int>();
            customLinked2.Head = new Node<int> { Value = 1 };
            customLinked2.Head.Next = new Node<int> { Value = 2 };
            customLinked2.Head.Next.Next = new Node<int> { Value = 2 };
            customLinked2.Head.Next.Next.Next = new Node<int> { Value = 3 };
            PrintHelpers.PrintArray("Remove Node with given key  Custom Linked List", customLinked2, RemoveNodeWithGivenKey.Remove(customLinked,2));


            // N from last Node in a linked list
            linked = new LinkedList<int>();
            linked.AddLast(1);
            linked.AddLast(2);
            linked.AddLast(2);
            linked.AddLast(3);
            linked2 = new LinkedList<int>();
            linked2.AddLast(1);
            linked2.AddLast(2);
            linked2.AddLast(2);
            linked2.AddLast(3);
            PrintHelpers.PrintArray("N from last Node in a linked list", linked2.ToArray(), new LinkedList<int>(new[] { NFromLastNode.GetNodeBasedOnPosition(linked, 2).Value}).ToArray(), "Node: 2");

            // N from last Node in a Custom linked list
            customLinked = new CustomLinkedList<int>();
            customLinked.Head = new Node<int> { Value = 1 };
            customLinked.Head.Next = new Node<int> { Value = 2 };
            customLinked.Head.Next.Next = new Node<int> { Value = 2 };
            customLinked.Head.Next.Next.Next = new Node<int> { Value = 3 };
            customLinked2 = new CustomLinkedList<int>();
            customLinked2.Head = new Node<int> { Value = 1 };
            customLinked2.Head.Next = new Node<int> { Value = 2 };
            customLinked2.Head.Next.Next = new Node<int> { Value = 2 };
            customLinked2.Head.Next.Next.Next = new Node<int> { Value = 3 };
            PrintHelpers.PrintArray("N from last Node in a custom linked list", customLinked2, new CustomLinkedList<int>
            {
                Head = new Node<int> { Value = NFromLastNode.GetNodeBasedOnPosition(customLinked, 2).Value }
            }, "Node: 2");


            Console.ReadKey();
        }

       
    }
}
