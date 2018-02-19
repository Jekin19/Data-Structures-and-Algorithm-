namespace CodeRust.LinkedLists
{
    //https://www.codeproject.com/Articles/1104980/Linked-List-Implementation-in-Csharp
    public class CustomLinkedList<T>
    {
        public Node<T> Head { get; set; }

        private Node<T> Current { get; set; }

        public bool AddLast(Node<T> node)
        {
            if(node== null)
            {
                return false;
            }
            if(Head == null)
            {
                Head = Current = node;
            }
            else
            {
                Current = Head;
                while(Current.Next != null)
                {
                    Current = Current.Next;
                }
                Current.Next = node;
                Current = Current.Next;
            }

            return true;
        }

        public bool AddLast(T value)
        {
            var node = new Node<T> { Value = value };
            return AddLast(node);
        }

    }

     public class Node<T> {

        public T Value { get; set; }

        public Node<T> Next { get; set; }

    }

    public static class NodeExtension { 
    
        public static int GetLength<T>(this Node<T> node)
        {
            int length = 0;
            while(node!= null)
            {
                length++;
                node = node.Next;
            }

            return length;
        }

        public static int GetLength<T>(this CustomLinkedList<T> linkedList)
        {
            int length = 0;
            if(linkedList == null)
            {
                return length;
            }
            var node = linkedList.Head;
            while (node != null)
            {
                length++;
                node = node.Next;
            }

            return length;
        }
    }
        
}
