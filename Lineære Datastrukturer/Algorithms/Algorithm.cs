using Library;
using System.Collections.Concurrent;
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
        //GFG edition
        public static GFG TreeSort(int[] Array) //This is made for int but could be made to support generics instead
        {
            GFG tree = new GFG();
            tree.treeins(Array);
            tree.inorderRec(tree.root);
            return tree;

        }

        //Lecture notes edition
        public static TreeNode treeSort(int[] Array) // it works but every number has to be unique and it also has lot of stackoverflow exceptions
        {
            TreeNode Root = null;
            for (int i = 0; i < Array.Length; i++)
            {
                Root = TreeNode.Insert(Root, Array[i]);
            }
            return Root;
        }

        public static int FillArray(TreeNode t, int[] a, int j)
        {
            if (t != null) //might be wrong
            {
                j = FillArray(t.Left, a, j);
                a[j++] = t.Key;
                j = FillArray(t.Right, a, j);
            }
            return j;
        }


        public static void HeapSort()
        {
            //check library for heapsorting
        }
        //left is startindex 
        //right is endindex
        public static int[] MergeSort(int[] a, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(a, left, mid);
                MergeSort(a, mid + 1, right);
                a = Merge(a, left, mid, right);
            }
            return a;
        }

        private static int[] Merge(int[] a, int left, int mid, int right)
        {
            int[] b = new int[right - left + 1];
            int bcount = 0;
            int lcount = left;
            int rcount = mid + 1;
            while ((lcount <= mid) && (rcount <= right))
            {
                if (a[lcount] <= a[rcount])
                {
                    b[bcount++] = a[lcount++];
                }
                else
                {
                    b[bcount++] = a[rcount++];
                }
            }
            if (lcount > mid)
            {
                while (rcount <= right)
                {
                    b[bcount++] = a[rcount++];
                }
            }
            else
            {
                while (lcount <= mid)
                {
                    b[bcount++] = a[lcount++];
                }
            }
            for (bcount = 0; bcount < right - left + 1; bcount++)
            {
                a[left + bcount] = b[bcount];
            }
            return a;
        }


        public static int[] HybridSorting(int[] a)
        {
            //quicksort faster at 100 and below
            //Bst(Opgave) faster at 1000 and above by alot but it broke and working with a mix of binary trees and non binary trees
            //so im using merge instead lol ;-; im in spain without the s
            // 1.000 and below is quicksort
            // 10.000 and above is mergesort
            if (a.Length <= 0)
                return a;
            if (a.Length > 10000)
            {
                GFGQuickSort.quickSort(a,0,a.Length-1);
                return a;
            }
            else
            {
                a = MergeSort(a, 0, a.Length - 1);
            }
            return a; //this is a slower way of doing it but thats fine
        }

    }
}
