using System;
using System.Collections.Generic;
using System.Text;

namespace StacksLL
{
    class Stack<T>
    {
        public int Count { get => data.Count; }
        private LinkedList<T> data;

        public Stack()
        {
            data = new LinkedList<T>();

        }

        public void Push(T value)
        {
            data.AddFirst(value);
        }

        public T Pop()
        {
            T value = data.First.Value;
            data.RemoveFirst();
            return value;
        }

        public T Peek()
        {
            T value = data.First.Value;
            return value;
        }
    }
}
