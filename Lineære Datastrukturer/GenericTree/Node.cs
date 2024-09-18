using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTree
{
    public class Node<T>
    {
        private T item;

        public Node(T item)
        {
            this.item = item;
        }
        public Node()
        {
            
        }
        public T Item { get => item; set => item = value; }
    }
    
}
