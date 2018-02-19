using System.Collections.Generic;

namespace CodeRust.LinkedLists
{
    public class SwapNnodeWithHead
    {
        public static LinkedList<int>  SwapBasedOnPosition(LinkedList<int> linkedList, int position)
        {

            if (linkedList == null || linkedList.First == null || position > linkedList.Count)
            {
                return linkedList;
            }

            var current = linkedList.First;
            for (int i = 0; i < position; i++)
            {
                current = current.Next;
            }

            if (current == null)
            {
                return linkedList;
            }

            var positionNode = linkedList.First;

            while (current != null)
            {
                current = current.Next;
                positionNode = positionNode.Next;
            }

            var temp = positionNode.Value;
            positionNode.Value = linkedList.First.Value;
            linkedList.First.Value = temp;

            return linkedList;
        }

        public static CustomLinkedList<int> SwapBasedOnPosition(CustomLinkedList<int> linkedList, int position)
        {
            if (linkedList == null || linkedList.Head == null)
            {
                return linkedList;
            }

            var current = linkedList.Head;
            for (int i = 0; i < position; i++)
            {
                current = current.Next;
            }

            if (current == null)
            {
                return linkedList;
            }

            var positionNode = linkedList.Head;

            while (current != null)
            {
                current = current.Next;
                positionNode = positionNode.Next;
            }

            var temp = positionNode.Value;
            positionNode.Value = linkedList.Head.Value;
            linkedList.Head.Value = temp;

            return linkedList;
        }
    }
}
