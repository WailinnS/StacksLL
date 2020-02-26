using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StacksLL
{
    class SingleLinkedList<T> : IEnumerable<T> where T : IComparable
    {
        public int Count { get; set; }
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public SingleLinkedList()
        {
            Head = null;
            Count = 0;
        }

        public void AddFirst(T value)
        {
            Node<T> temp = new Node<T>(value, ownList: this);

            if (Count == 0)
            {
                Head = temp;
                Tail = Head;
                Count++;
            }
            
            temp.nextNode = Head;

            Head = temp;
            
            Count++;

        }

        public void AddLast(T value)
        {
            if (Count == 0)
            {
               AddFirst(value);
            }
            else
            {
                Node<T> current = Head;
                while (current.nextNode != null)
                {
                    current = current.nextNode;
                }

                current.nextNode = new Node<T>(value, ownList: this);
                Tail = current;
                Count++;
            }

        }

        public Node<T> Find(T node)
        {
            Node<T> temp = Head;
            while (temp.nextNode != null)
            {
                if (temp.value.Equals(node))
                {
                    return temp;
                }
                temp = temp.nextNode;
            }
            return null;
        }

        public void AddAfter(Node<T> nodeToAddAfter, T value)
        {
            if (nodeToAddAfter == null)
            {
                AddLast(value);
                return;
            }

            Node<T> newNode = new Node<T>(value, ownList: this);
            newNode.nextNode = nodeToAddAfter.nextNode;
            nodeToAddAfter.nextNode = newNode;
            Count++;
        }

        public void AddBefore(Node<T> nodeToAddBefore, T value)
        {
            if (nodeToAddBefore == null)
            {
                AddLast(value);
                return;
            }
            if (nodeToAddBefore == Head)
            {
                AddFirst(value);
                return;
            }

            Node<T> temp = Head;

            while (temp.nextNode != nodeToAddBefore)
            {
                temp = temp.nextNode;
            }

            Node<T> newNode = new Node<T>(value, ownList: this);

            newNode.nextNode = nodeToAddBefore;

            temp.nextNode = newNode;
            Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> list = Head;
            
           while(list.nextNode != null)
            { 
                yield return Head.value;
                list = list.nextNode;
            } 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // a way but assumes user knows position.
        //public void AddBefore(int position, T value)
        //{

        //    Node<T> temp = head;
        //    for (int i = 0; i < position - 1; i++)
        //    {
        //        temp = temp.nextNode;
        //    }
        //    Node<T> current = new Node<T>(value);
        //    current.nextNode = temp.nextNode;
        //    temp.nextNode = current;
        //    size++;

        //}


    }
}
