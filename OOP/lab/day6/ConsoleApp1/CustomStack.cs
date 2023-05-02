using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CustomStack<T> : IStack<T>
    {
        private T[] _items;
        private int _top;

        public CustomStack(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity cannot be negative.");
            }
            _items = new T[capacity];
            _top = -1;
        }

        public void Push(T item)
        {
            if (_top == _items.Length - 1)
            {
                throw new CustomStackException("Stack is full.");
            }
            _items[++_top] = item;
        }

        public T Pop()
        {
            if (_top == -1)
            {
                throw new CustomStackException("Stack is empty.");
            }
            return _items[_top--];
        }

    }
}
