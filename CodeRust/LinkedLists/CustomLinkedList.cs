namespace CodeRust.LinkedLists
{
    public class CustomLinkedList<T>
    {
        public Node<T> Head { get; set; }

        public Node<T> Current { get; set; }

    }

     public class Node<T> {

        public T Value { get; set; }

        public Node<T> Next { get; set; }

    }

}
