using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructures
{
    public class CustomList<T> : CustomLinearData<T>
    {

        public CustomList(int initialLength = 0) : base(initialLength)
        {
            
        }

        public void Add(T item)
        {
            Insert(item);
        }

        public void AddAt(int index, T item)
        {
            InsertAt(index, item);
        }

        public void RemoveAt(int Index)
        {
            base.RemoveAt(Index);
        }

        public int Count()
        {
            return base.Count;
        }


    }
}
