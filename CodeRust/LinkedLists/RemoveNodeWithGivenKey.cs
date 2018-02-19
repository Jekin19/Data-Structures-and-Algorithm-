using System.Collections.Generic;

namespace CodeRust.LinkedLists
{
    public class RemoveNodeWithGivenKey
    {
        public static LinkedList<int> Remove(LinkedList<int> linkedList, int key)
        {
            var current = linkedList.First;
            while (current != null)
            {
                if (key == current.Value)
                {
                    var temp = current.Next;
                    // In Built method
                    linkedList.Remove(current);
                    current = temp;

                }
                else
                {
                    current = current.Next;
                }
            }

            return linkedList;
        }

        public static CustomLinkedList<int> Remove(CustomLinkedList<int> linkedList, int key)
        {
            if (linkedList == null || linkedList.Head == null)
            {
                return linkedList;
            }

            var current = linkedList.Head;
            while(current!= null && current.Value == key)
            {
                current = current.Next;
            }
            var previous = current;
            current = current.Next;

            while (current != null)
            {
                if (current.Value == key)
                {
                    previous.Next = current.Next;
                }
                else
                {
                    previous = current;
                }
                current = current.Next;

            }

            return linkedList;
        }
    }
}
