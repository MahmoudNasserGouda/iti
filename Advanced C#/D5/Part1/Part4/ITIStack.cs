using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    public class ITIStack<T>
    {
        private T[] Items;
        int top = 0;
        public ITIStack(int _size)
        {
            Items = new T[_size];
        }
        public void Push(T item)
        {
            Items[top] = item;
            top++;
        }
        public T Pop()
        {
            top--;
            return Items[top];
        }
    }
}
