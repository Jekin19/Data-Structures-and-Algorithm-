using System;
using System.Collections.Generic;

namespace CodeRust.LinkedLists
{
    public class IntersectionPointOfTwoLists
    {
        public static LinkedListNode<int> GetIntersectionNode(LinkedList<int> linkedList1 , LinkedList<int> linkedList2)
        {
            if(linkedList1 == null || linkedList2 == null)
            {
                return null;
            }
            LinkedList<int> shortLinkedList;
            LinkedList<int> longLinkedList;
            if(linkedList1.Count > linkedList2.Count)
            {
                shortLinkedList = linkedList2;
                longLinkedList = linkedList1;
            }
            else
            {
                shortLinkedList = linkedList1;
                longLinkedList = linkedList2;
            }

            LinkedListNode<int> shortLinkedListHead = shortLinkedList.First;
            LinkedListNode<int> longLinkedListHead = longLinkedList.First;
            for (int i = 0; i < longLinkedList.Count - shortLinkedList.Count;i++)
            {
                longLinkedListHead = longLinkedListHead.Next;
            }

            while(shortLinkedListHead.Next != null)
            {
                if(shortLinkedListHead.Equals(longLinkedListHead))
                {
                    return shortLinkedListHead;
                }
                shortLinkedListHead = shortLinkedListHead.Next;
                longLinkedListHead = longLinkedListHead.Next;
            }

            return null;
        }

        public static Node<int> GetIntersectionNode(CustomLinkedList<int> linkedList1, CustomLinkedList<int> linkedList2)
        {
            if (linkedList1 == null || linkedList2 == null)
            {
                return null;
            }


            CustomLinkedList<int> shortLinkedList;
            CustomLinkedList<int> longLinkedList;
            if (linkedList1.GetLength() > linkedList2.GetLength())
            {
                shortLinkedList = linkedList2;
                longLinkedList = linkedList1;
            }
            else
            {
                shortLinkedList = linkedList1;
                longLinkedList = linkedList2;
            }

            Node<int> shortLinkedListHead = shortLinkedList.Head;
            Node<int> longLinkedListHead = longLinkedList.Head;
            for (int i = 0; i < longLinkedList.GetLength() - shortLinkedList.GetLength(); i++)
            {
                longLinkedListHead = longLinkedListHead.Next;
            }

            while (shortLinkedListHead.Next != null)
            {
                if (shortLinkedListHead.Equals(longLinkedListHead))
                {
                    return shortLinkedListHead;
                }
                shortLinkedListHead = shortLinkedListHead.Next;
                longLinkedListHead = longLinkedListHead.Next;
            }

            return null;
        }
    }
}
