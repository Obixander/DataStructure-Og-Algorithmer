using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class HeapTreeTesting
    {



        public HeapTreeTesting(int maxLength)
        {
            Max = maxLength;
        }
        public static int Max { get; set; } //change this from static lol

        //something lol

        public static Boolean isRoot(int i)
        {
            return i == 1;
        }

        //public int level(int i)
        //{
        //    return log(i);
        //}

        public static int Parent(int i)
        {
            return i / 2;
        }

        public static int left(int i)
        {
            return 2 * i;
        }

        public static int right(int i)
        {
            return 2 * i + 1;
        }



        //something else 

        public static Boolean heapEmpty(int[] heap, int n) //checks if the heap tree is empty
        {
            return n == 0;
        }

        public static int root(int[] heap, int n) //gets the root of the heap tree if the tree is not empty
        {
            if (heapEmpty(heap, n))
            {
                throw new Exception("Heap is empty");
            }
            else
            {
                return heap[1];
            }
        }

        public static int lastLeaf(int[] heap, int n) //returns the value at n? why idk ;-;
        {
            if (heapEmpty(heap, n))
            {
                throw new Exception("Heap is empty");
            }
            else
            {
                return heap[n];
            }
        }

        public static void insert(int p, int[] heap, int n)
        {
            if (n == Max)
                throw new Exception("Heap is full");

            else
            {
                heap[n + 1] = p;
                bubbleUp(n + 1, heap, n + 1);
            }
        }

        public static void bubbleUp(int i, int[] heap, int n)
        {
            if (isRoot(i))
            {
                return;
            }
            else if (heap[i] > heap[Parent(i)])
            {
                var temp = heap[i];
                heap[i] = heap[Parent(i)];
                heap[Parent(i)] = temp;
                bubbleUp(Parent(i),heap, n);
            }
        }

        public static void bubbleDown(int i, int[] heap, int n)
        {
            if (left(i) > n)
            {
                return;
            }
            else if (right(i) > n)
            {
                if (heap[i] < heap[left(i)])
                {
                    var temp = heap[i];
                    heap[i] = heap[left(i)];
                    heap[left(i)] = temp;
                }
            }
            else
            {
                if (heap[left(i)] > heap[right(i)] && heap[i] < heap[left(i)])
                {
                    var temp = heap[i];
                    heap[i] = heap[left(i)];
                    heap[left(i)] = temp;
                    bubbleDown(left(i),heap, n);
                }
                else if (heap[i] < heap[right(i)])
                {
                    var temp = heap[i];
                    heap[i] = heap[right(i)];
                    heap[right(i)] = temp;
                    bubbleDown(right(i),heap,n);
                }
            }
        }

    }
}
