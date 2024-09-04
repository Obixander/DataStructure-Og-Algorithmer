using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
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

        protected virtual void ResizeTo(int newLength) //this has to be entirely rewritten as it does not work as expected
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

    public abstract class CustomLinearData<T>
    {
        private T[] array; // the array of data for the custom datatype
        protected int length; // the length of the array
        protected int count; // the number of elements in the array
        private int arrayLengthChangeAmount; // the amount the array will increase in size when it is resized default is 1
        protected CustomLinearData(int intitalLength)
        {
            array = new T[intitalLength];
            length = array.Length;
            count = 0;
            arrayLengthChangeAmount = 1;
        }

        private T[] Array
        {
            get => array;
            set
            {
                if (array != value)
                {
                    array = value;
                    length = array.Length;
                }

            }
        }

        private int ArrayLengthChangeAmount { get => arrayLengthChangeAmount; set => arrayLengthChangeAmount = value; }
        protected int Length //How Long the array is
        {
            get => length;
            set => length = value;
        }
        protected int Count //Amount of items in the array
        {
            get => count;
            set => count = value;
        }

        protected virtual void Insert(T item, int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else if (index == array.Length)
            {
                Resize(index);
            }
            else if (index > array.Length)
            {
                Resize(index);
            }

            array[index] = item;
            count++;
            length = array.Length;

        }
        protected virtual void Remove(int index)
        {
            //This method removes an element from the array at the specified index by shifting all elements to the left
            if (index < 0 || index >= length)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = index; i < length - 1 - 1; i++)
            {
                array[i] = array[i + 1];
            }
            count--;
        }
        //this method is used to resize the array when it is full or when a index position is removed
        protected virtual void Resize(int NewLength)
        {
            try
            {
                if (NewLength < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                NewLength = NewLength + arrayLengthChangeAmount; //
                T[] newArray = new T[NewLength];
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
                length = array.Length;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Removes the top part of the stack and returns that value
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        protected virtual T StackRemove() 
        {
            Length = array.Length;
            if (Length <= 0)
            {
                throw new Exception("The Stack is Empty");
            }
            T temp = array[Length - 1]; //this should always get the last in the array
            if (Length == 1) 
            {
                array = new T[0]; // find a better way to do this
                return temp;
            }
            var TempArray = array;
            array = new T[array.Length - 1];
            for (int i = 0; i < TempArray.Length-1; i++)
            {
                array[i] = TempArray[i];
            }
            return temp;
        }

        protected virtual void ConfigResize(int NewValue)
        {
            if (NewValue <= 0)
            {
                throw new ArgumentOutOfRangeException("Minium Value is 1");
            }
            if (NewValue != arrayLengthChangeAmount)
            {
                arrayLengthChangeAmount = NewValue;
            }
        }


        protected virtual int FirstIndexOf(T value)
        {
            if (array.Length == 0 || array == null)
            {
                return -1;
            }


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        protected virtual T[] getArray()
        {
            return array;
        }
        protected virtual T GetValue(int index)
        {
            return array[index];
        } 
    }


    public class CustomList<T> : CustomLinearData<T>
    {
        public CustomList(int initialLength = 0) : base(initialLength) //initialLength = 0 is so that you can make an list with no specified starting length
        {

        }
        public void Add(T item, int index)
        {
            Insert(item, index);
        }

        public void RemoveAt(int index)
        {
            Remove(index);
        }
        public int GetLength()
        {
            return Length;
        }
        public void ChangeResizeValue(int Value)
        {
            ConfigResize(Value);
        }
        

    }

    public class CustomStack<T> : CustomLinearData<T>
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

        public CustomStack(int initialLength = 0) : base(initialLength)
        {
            LastStack = 0;
        }

        public int GetLength()
        {
            return Length;
        }
        /// <summary>
        /// This Method is used on a customstack<T> and the caller top value is pop'd and pushed to the array specifed as a paramter
        /// </summary>
        /// <param name="GoToArray">The Array the value will go to</param>
        public void PopPushTo(CustomStack<T> GoToArray) 
        {
            if (GetLength() > 0) //gets the length of the array popping to prevent index exceptions
            {
                int temp = int.Parse(Get(GetLength() - 1).ToString());
                int temp2 = 99;
                if (GoToArray.length > 0)
                {
                    temp2 = int.Parse(GoToArray.Get(GoToArray.GetLength() - 1).ToString());
                }
                if (temp < temp2 )
                {
                    GoToArray.Push(Pop());
                    Length--;
                }
            }

        }


        public void Push(T item)
        {
            if (length < LastStack+1)
            {
               Resize(lastStack);
            }
            Insert(item, LastStack);
            LastStack++;
            
        }
        /// <summary>
        /// Removes the Top of the stack
        /// </summary>
        public T Pop()
        {
            LastStack--;
            Length--;
            return StackRemove();
        }

        public bool IsPalindrom() //WORKS FIRST TRY WOOWOOWOWOWOWOOWWOOW!!!!!
        {
            T[] array = getArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (!array[i].Equals(array[array.Length-i-1]))
                {
                    return false;
                }
            }

            return true;
        }

        public T Get(int index) // dont use otherside of hanoi tower case
        {
            return GetValue(index);
        } 




    }
}
