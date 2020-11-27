using System;

namespace DoubleLinkedList
{
    public class Node
    {
        public int Value { get; set; }
        public Node Prev { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
            Next = null;
            Prev = null;
        }

        public Node()
        {
            Next = null;
            Prev = null;
        }

        public Node(Node node)
        {
            Next = node.Next;
            Prev = node.Prev;
            Value = node.Value;
        }
    }
}
