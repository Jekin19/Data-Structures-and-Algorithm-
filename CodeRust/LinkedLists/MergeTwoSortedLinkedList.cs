using System;
using System.Collections.Generic;

namespace CodeRust.LinkedLists
{
    public class MergeTwoSortedLinkedList
    {
        public static LinkedList<int> GetMergedList(LinkedList<int> linkedList1, LinkedList<int> linkedList2)
        {
            LinkedList<int> result = new LinkedList<int>();
            if(linkedList1 == null )
            {
                return linkedList2;
            }
            if (linkedList2 == null)
            {
                return linkedList1;
            }
            var linkedList1Head = linkedList1.First;
            var linkedList2Head = linkedList2.First;

            while(linkedList1Head != null && linkedList2Head != null)
            {
                if (linkedList1Head.Value > linkedList2Head.Value)
                {
                    result.AddLast(linkedList2Head.Value);
                    linkedList2Head = linkedList2Head.Next;
                }
                else
                {
                    result.AddLast(linkedList1Head.Value);
                    linkedList1Head = linkedList1Head.Next;
                }
            }

            if(linkedList1Head != null)
            {
                while(linkedList1Head != null)
                {
                    result.AddLast(linkedList1Head.Value);
                    linkedList1Head = linkedList1Head.Next;
                }
            }


            if (linkedList2Head != null)
            {
                while (linkedList2Head != null)
                {
                    result.AddLast(linkedList2Head.Value);
                    linkedList2Head = linkedList2Head.Next;
                }
            }


            return result;
        }

        public static CustomLinkedList<int> GetMergedList(CustomLinkedList<int> linkedList1, CustomLinkedList<int> linkedList2)
        {
            CustomLinkedList<int> result = new CustomLinkedList<int>();
            if (linkedList1 == null)
            {
                return linkedList2;
            }
            if (linkedList2 == null)
            {
                return linkedList1;
            }
            var linkedList1Head = linkedList1.Head;
            var linkedList2Head = linkedList2.Head;

            while (linkedList1Head != null && linkedList2Head != null)
            {
                if (linkedList1Head.Value > linkedList2Head.Value)
                {
                    result.AddLast(linkedList2Head.Value);
                    linkedList2Head = linkedList2Head.Next;
                }
                else
                {
                    result.AddLast(linkedList1Head.Value);
                    linkedList1Head = linkedList1Head.Next;
                }
            }

            if (linkedList1Head != null)
            {
                while (linkedList1Head != null)
                {
                    result.AddLast(linkedList1Head.Value);
                    linkedList1Head = linkedList1Head.Next;
                }
            }


            if (linkedList2Head != null)
            {
                while (linkedList2Head != null)
                {
                    result.AddLast(linkedList2Head.Value);
                    linkedList2Head = linkedList2Head.Next;
                }
            }


            return result;
        }


    }
}
