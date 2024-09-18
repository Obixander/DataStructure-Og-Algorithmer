using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CustomDataStructures
{
    public class CustomStack<T> : CustomLinearData<T>
    {
        private int lastStack;

        public CustomStack(int intitialLength = 0) : base(intitialLength)
        {
            lastStack = 0;
        }

        protected int LastStack
        {
            get
            {
                return lastStack;
            }
            set => lastStack = value;
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
                int temp = int.Parse(Peek(GetLength() - 1).ToString());
                int temp2 = 99;
                if (GoToArray.Length > 0)
                {
                    temp2 = int.Parse(GoToArray.Peek(GoToArray.GetLength() - 1).ToString());
                }
                if (temp < temp2)
                {
                    GoToArray.Push(Pop());
                    Length--;
                }
            }
        }


        public void Push(T item)
        {
            if (Length < LastStack + 1)
            {
                ResizeArrayTo(lastStack);
            }
            InsertAt(LastStack, item);
            LastStack++;

        }
        /// <summary>
        /// Removes the Top of the stack
        /// </summary>
        public T Pop()
        {
            if (Length <= 0)
            {
                throw new Exception("The Stack is Empty");
            }
            T temp;
         
                temp = Array[Length-1]; //this should always get the last in the array
               
            if (Length == 1)
            {
                Array = new T[0]; // find a better way to do this
                return temp;
            }

            var TempArray = Array;
            ResizeArrayTo(Length - 1);
            for (int i = 0; i < TempArray.Length - 1; i++)
            {
                Array[i] = TempArray[i];
            }
            Length = Array.Length;
            return temp;

        }

        public bool IsPalindrom() //WORKS FIRST TRY WOOWOOWOWOWOWOOWWOOW!!!!!
        {

            for (int i = 0; i < Length; i++)
            {
                if (!Array[i].Equals(Array[Length - i - 1]))
                {
                    return false;
                }
            }

            return true;
        }

        public T Peek(int index) // dont use otherside of hanoi tower case
        {
            return Array[index];
        }




    }
}
