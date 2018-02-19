using System;
using System.Collections.Generic;

namespace CodeRust.LinkedLists
{
    public class NFromLastNode
    {
        public static LinkedListNode<int> GetNodeBasedOnPosition(LinkedList<int> linkedList, int position)
        {
           
            if (linkedList ==null || linkedList.First ==null || position > linkedList.Count)
            {
                return new LinkedListNode<int>(-1);
            }

            var current = linkedList.First;
            for (int i = 0; i < position; i++)
            {
                current = current.Next;
            }

            if (current == null)
            {
                return new LinkedListNode<int>(-1);
            }

            var positionNode = linkedList.First;

            while (current != null)
            {
                current = current.Next;
                positionNode = positionNode.Next;
            }

            return positionNode;
        }

        public static Node<int> GetNodeBasedOnPosition(CustomLinkedList<int> linkedList, int position)
        {


            if (linkedList == null || linkedList.Head == null)
            {
                return new Node<int>();
            }

            var current = linkedList.Head;
            for (int i = 0; i < position; i++)
            {
                current = current.Next;
            }

            if(current == null)
            {
                return new Node<int>();
            }

            var positionNode = linkedList.Head;

            while (current != null)
            {
                current = current.Next;
                positionNode = positionNode.Next;
            }


            return positionNode;
        }
    }
}
