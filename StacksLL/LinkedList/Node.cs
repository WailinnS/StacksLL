using System;
using System.Collections.Generic;
using System.Text;

namespace StacksLL
{
    class Node<T> where T : IComparable
    {
        public SingleLinkedList<T> OwnList { get; }

        public T value;
        public Node<T> nextNode;
        public Node(T data, SingleLinkedList<T> ownList)
        {
            value = data;
            OwnList = ownList;
            nextNode = null;
        }
    }
}
