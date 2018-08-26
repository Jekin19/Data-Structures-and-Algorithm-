using System;
namespace CodeRust.BinaryTrees
{
    public class Node<T>
    {
        // Private member-variables
        private T data;

        public Node() { }
        public Node(T data) : this(data, new NodeList<T>()) { }
        public Node(T data, NodeList<T> neighbors)
        {
            this.data = data;
            this.Neighbors = neighbors;
        }

        public T Value
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public NodeList<T> Neighbors { get; set; } = new NodeList<T>();
    }

}
