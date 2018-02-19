using System.Collections.Generic;

namespace CodeRust.LinkedLists
{
    public class ReverseLinkedList
    {
        public static LinkedList<int> Reverse(LinkedList<int> linkedList)
        {
            LinkedListNode<int> start = linkedList.First;
            LinkedListNode<int> last = linkedList.Last;

            while (start.Next != last && start != last)
            {
                int temp = start.Value;
                start.Value = last.Value;
                last.Value = temp;

                start = start.Next;
                last = last.Previous;
            }
            return linkedList;
        }

        public static Node<int> Reverse(CustomLinkedList<int> linkedList)
        {
            if (linkedList == null || linkedList.Head == null )
            {
                return null;
            }

            Node<int> previous = linkedList.Head;
            Node<int> current = linkedList.Head.Next;
            previous.Next = null;

            while(current!=null)
            {
                var temp = current;
                current = current.Next;
                temp.Next = previous;
                previous = temp;
            }

            return previous;
        }

       
    }
}
