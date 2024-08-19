using Library;
using System.Numerics;

namespace Algorithms
{
    public class Algorithm
    {
        public Algorithm()
        {

        }
        //is there any way to make this method generic? or more then just int[]?
        public static bool IsSorted(int[] Array) // This is a method that checks if an array is sorted
        {
            for (int i = 0; i < Array.Length - 1; i++)
            {
                if (Array[(int)i] > Array[(int)i + 1])
                    return false;
            }
            return true;
        }


        //ITS ALIVE 
        public static int BinarySearch(int[] Array, int Key) // only for sorted int arrays with unique elements
        {
            int left = 0;
            int right = Array.Length - 1; // n in the this
            while (left < right)
            {
                int mid = (left + right) / 2;
                if (Key > Array[(int)mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
                if (Array[(int)left] == Key) // if the key is found
                {
                    return left;
                }
            }
            return -1; // if the key is not found
        }
        public static int BinarySearchLast(int[] Array, int Key) // only for sorted int arrays with unique elements
        {
            int left = 0;
            int right = Array.Length - 1; // n in the this
            while (left < right)
            {
                int mid = (left + right) / 2;
                if (Key > Array[(int)mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
                if (Array[(int)left] == Key) // if the key is found
                {
                    while (Array[left] == Key)
                    {
                        left++;
                    }
                    left--;
                    return left;
                }
            }
            return -1; // if the key is not found
        }

        public static int BinarySearchFirst(int[] Array, int Key) //this returns the left most index of the key
        {
            int left = 0;
            int right = Array.Length - 1; // n in the this
            while (left < right)
            {
                int mid = (left + right) / 2;
                if (Key > Array[(int)mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
                if (Array[(int)left] == Key) // if the key is found
                {
                    while (Array[left] == Key)
                    {
                        left--;
                    }
                    left++;
                    return left;
                }
            }
            return -1; // if the key is not found
        }





        public static int LinearSearch(int[] Array, int Key)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == Key)
                {
                    return i;
                }
            }
            return -1;
        }


        //Opgave 15.1

        //Bubble Sortering algorithm
        public static int[] BubbleSort(int[] Array) //Accepts int[]
        {
            for (int i = 1; i < Array.Length; i++)
            {
                for (int j = Array.Length - 1; j >= i; j--)
                {
                    if (Array[j] < Array[j - 1])
                    {
                        //this should swap these
                        int temp = Array[j];
                        Array[j] = Array[j - 1];
                        Array[j - 1] = temp;
                    }
                }

            }
            return Array;
        }

        //Inserting sortering algorithm
        //slow version maybe?
        public static int[] InsertSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        var temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
            return array;
        }

        //this much faster then the other insertSort(use this i guess)
        public static int[] InsertSortFast(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                int temp = array[j];
                while (j > 0 && temp < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = temp;
            }
            return array;
        }

        //Selection sorting 
        //Pretty good but InsertSort(Fast) is faster
        public static int[] SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int k = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[k])
                        k = j;
                }
                int temp = array[i];
                array[i] = array[k];
                array[k] = temp;
            }
            return array;
        }

        public static int[] TreeSort(int[] a) //This is made for int but could be made to support generics instead
        {
            

            return null;
        }


    }
}
