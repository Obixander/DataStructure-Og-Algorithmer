using System.CodeDom.Compiler;
using System.Drawing;
using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace DataStructures
{

    public abstract class LinearDataStructure<T>
    {
        private T[] array;
        private int length;
        protected int count;
        private int sizeChange; //the aditional amount an array changes default = 1;

        protected LinearDataStructure(int length)
        {
            array = new T[length];
            this.length = length;
            count = 0;
            sizeChange = 1;
        }

        public int Count
        {
            get => count;
            set
            {
                if (array != null)
                    count = array.Length;
            }
        }
        private T[] Array
        {
            get => array;
            set
            {
                if (array != value)
                {
                    array = value;
                    Length = array.Length;
                }
                
            }
        }
        private int Length { get => length; set => length = value; }
        protected int SizeChange { get => sizeChange; set => sizeChange = value; }

        protected virtual void Insert(T item, int index)
        {
            if (index < 0 || index > length)
            {
                throw new IndexOutOfRangeException();
            }

            if (index >= length)
            {
                ResizeTo(index);
            }
            array[index] = item; 
        }
        //add another method to move the array back 1 after index
        protected virtual void Remove2(int index)
        {
            if (index < 0 && index >= array.Length)
            {
                throw new IndexOutOfRangeException();
            }
            
            for (int i = index; i < length; i++)
            {
                if (i + 1 < length)
                array[i] = array[i + 1];    
            }
            ResizeTo(array.Length - 1);
        }

        protected virtual void Remove(int index) // index = 5 array is 10
        {
            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException();
            }

            var temp = new T[index];
            var temp2 = new T[Array.Length - index-1];
            for (int i = 0; i < index; i++)
            {
               temp[i] = array[i];
            }
            int counter = 0;
            for (int i = index+1; i < array.Length; i++)
            {
                temp2[counter] = array[i];
                counter++;
            }
            ResizeTo(array.Length - 1);
            counter = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                array[i] = temp[i];
                counter++;
            }

            for (int i = 0; i < temp2.Length; i++)
            {
                array[counter] = temp2[i];
                counter++;
            }
        }

        protected virtual void ResizeTo(int newLength) //Configable
        {            
            var temp = array;
            array = new T[newLength];
            length = newLength;
            for (int i = 0; i < temp.Length-1; i++) //does not work how i want it to
            {
                array[i] = temp[i];
            }
        }
        protected void ChangeResize(int newValue)
        {
            if (newValue != sizeChange && newValue >= 0)
            {
                sizeChange = newValue;
            }
            else
            {
                if (newValue < 0)
                {
                    throw new Exception("Resize Amount cannot go below 0");
                }

            }            
        }

        protected int GetLength()
        {
            return array.Length;
        }

    }
    public class CustomList<T> : LinearDataStructure<T>
    {
        public CustomList(int initialLength) : base(initialLength)
        {

        }
        public void Add(T item, int index)
        {
            Insert(item, index);
        }

        public void RemoveAt(int index)
        {
            Remove2(index);
        }
        public int Length()
        {
            return GetLength();
        }
        public void ChangeResizeValue(int Value)
        {
            ChangeResize(Value);
        }

    }

    public class CustomStack<T> : LinearDataStructure<T>
    {
        private int lastStack;

        protected int LastStack
        {
            get
            {
                return lastStack;
            }
            set => lastStack = value;
        }

        public CustomStack(int initialLength) : base(initialLength)
        {
            LastStack = 0;
        }

        public void Push(T item)
        {
            if (GetLength() < LastStack+1)
            {
                ResizeTo(lastStack);
            }
            Insert(item, LastStack);
            LastStack++;
        }

        public void Pop()
        {
            Remove2(GetLength()-1);
        }

        protected override void ResizeTo(int newLength)
        {
            
            base.ResizeTo(newLength+1);
        }

    }
}
