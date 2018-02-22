
namespace CodeRust.LinkedLists
{
    public class RotateLinkedList
    {
        public static CustomLinkedList<int> Rotate(CustomLinkedList<int> linkedList, int rotate)
        {
            if (linkedList == null || linkedList.Head == null)
            {
                return null;
            }
            int counter = 1;
            var start = linkedList.Head;
            while (counter < rotate)
            {
                start = start.Next;
                counter++;
            }

            var rotateNode = start;
            while(start.Next != null)
            {
                start = start.Next;
            }

            start.Next = linkedList.Head;
            linkedList.Head = rotateNode.Next;
            rotateNode.Next = null;
            return linkedList;


        }
    }
}
