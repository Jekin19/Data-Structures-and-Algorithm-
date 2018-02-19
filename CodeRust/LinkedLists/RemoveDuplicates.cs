using System;
using System.Collections.Generic;

namespace CodeRust.LinkedLists
{
    public class RemoveDuplicates
    {
        public static LinkedList<int> RemoveDuplicate(LinkedList<int> linkedList)
        {
            HashSet<int> set = new HashSet<int>();
            var start = linkedList.First;
            while(start != null)
            {
                if(set.Contains(start.Value))
                {
                    linkedList.Remove(start);
                }
                set.Add(start.Value);
                start = start.Next;
            }

            return linkedList;
        }

    }
}
