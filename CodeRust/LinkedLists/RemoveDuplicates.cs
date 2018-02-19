using System;
using System.Collections.Generic;

namespace CodeRust.LinkedLists
{
    public class RemoveDuplicates
    {
        public static LinkedList<int> RemoveDuplicate(LinkedList<int> linkedList)
        {
            HashSet<int> set = new HashSet<int>();
            var current = linkedList.First.Next;
            while(current != null)
            {
                if(set.Contains(current.Value))
                {
                    // In Built method
                     linkedList.Remove(current);

                }
                set.Add(current.Value);
                current = current.Next;

            }

            return linkedList;
        }

        public static CustomLinkedList<int> RemoveDuplicate(CustomLinkedList<int> linkedList)
        {
            if(linkedList == null || linkedList.Head == null || linkedList.Head.Next == null)
            {
                return linkedList;
            }

            HashSet<int> set = new HashSet<int>();
            var previous = linkedList.Head;
            set.Add(previous.Value);

            var current = linkedList.Head.Next;
            while (current != null)
            {
                if (set.Contains(current.Value))
                {
                    previous.Next = current.Next;
                }
                else
                { 
                    set.Add(current.Value);
                    previous = current;
                }
                current = current.Next;

            }

            return linkedList;
        }

    }
}
