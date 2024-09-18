using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructures
{

    public class Node<T>
    {
        private T data;
        private Node<T> next;
        public Node(T data)
        {
            this.data = data;
            next = null;
        }

        public T Data { get => data; set => data = value; }
        public Node<T> Next { get => next; set => next = value; }
    }

    public class CustomLinkedList<T>
    {
        private Node<T> head;
        public CustomLinkedList()
        {
            Head = null;
        }
       

        public Node<T> Head { get => head; set => head = value; }
    
        //Methods

        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node<T> temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }
        
        public void Remove(T value)
        {
            Node<T> temp = Head;
            while (temp.Next != null)
            {
               if (temp.Next.Data.Equals(value))
                {
                    var tempnext = temp.Next.Next;
                    temp.Next = tempnext;
                    break;
                }
                temp = temp.Next;
            }
            
        }

    }

    
}
