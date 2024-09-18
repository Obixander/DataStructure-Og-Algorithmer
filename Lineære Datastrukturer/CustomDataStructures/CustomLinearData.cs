namespace CustomDataStructures
{
    public abstract class CustomLinearData<T>
    {
        private T[] array;
        private int count; //used for lists
        private int length; //used for arrays

        public CustomLinearData(int IntitalLength)
        {
            Length = IntitalLength;
            array = new T[Length];
            count = 0;
        }

        public T[] Array
        {
            get => array;
            set
            {
                array = value;
                Length = array.Length;
            }
        }
        protected int Count { get => count; set => count = value; }
        protected int Length { get => length; set => length = value; }

        protected virtual void InsertAt(int index, T item)
        {
            if (index < 0)
                throw new IndexOutOfRangeException("Index is out of range");
            if (index >= Length)
            {
                ResizeArrayTo(index + 1); //Maybe change from 1 to something more to redunce the number of resizes
            }
            array[index] = item;
            count++;
        }

        protected virtual void Insert(T item)
        {
            InsertAt(Count, item);
        }

        protected virtual void RemoveAt(int index)
        {
            if (index < 0 && index >= array.Length)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < length - 1; i++)
            {
                if (i + 1 < length)
                    array[i] = array[i + 1];
            }
            ResizeArrayTo(array.Length - 1);
            count--;
        }

        protected virtual void ResizeArrayTo(int NewLength)
        {
            if (NewLength < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            T[] newArray = new T[NewLength];
            for (int i = 0; i < NewLength; i++)
            {
                if (array.Length > i)
                newArray[i] = array[i];
            }
            Array = newArray;
            Length = array.Length;
        }



    }
}
