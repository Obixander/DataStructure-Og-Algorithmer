using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructures
{
    public class CustomSequence<T> : CustomLinearData<T> 
    {
        private int CurrentIndex;

        public CustomSequence(int initialLength = 0) : base(initialLength)
        {
            CurrentIndex = 0;
        }

        public T Next()
        {
            CurrentIndex++;
            return Array[CurrentIndex];
        }

        public T Current()
        {
            return Array[CurrentIndex];
        }

        public T previous()
        {
            CurrentIndex--;
            return Array[CurrentIndex];
        }

        public void Add(T item)
        {
            Insert(item);
        }

        public int Length()
        {
            return base.Length;
        }

        public void Reverse()
        {
          System.Array.Reverse(Array);
        }

        public void Clear()
        {
            int counter = base.Length;
            for (int i = 0; i < counter; i++)
            {
                RemoveAt(i);
            }
        }
    }
}
