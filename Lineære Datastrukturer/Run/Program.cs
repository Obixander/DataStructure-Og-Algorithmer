using Algorithms;
using DataStructures;
using Library;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Run
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                //for (int i = 10; i <= 10; i *= 10)
                //{
                //    CustomList<int> test = new CustomList<int>(5);
                //    for (int j = 0; j < test.GetLength(); j++)
                //    {
                //        test.Add(j, j);
                //    }
                //    var timer = new Stopwatch();
                //    timer.Start();
                //    test.RemoveAt(test.GetLength() - 1);
                //    timer.Stop();
                //    Console.WriteLine("Time: " + timer.ElapsedTicks + " Size: " + i);
                //}

                CustomStack<int> a1 = new CustomStack<int>();
                CustomStack<int> a2 = new CustomStack<int>();
                CustomStack<int> a3 = new CustomStack<int>();

                a1.Push(4);
                a1.Push(3);
                a1.Push(2);
                a1.Push(1);

                Hanoi(a1,a2,a3, a1.GetLength());
           
            }

        }

        public static void Hanoi(CustomStack<int> a1, CustomStack<int> a2, CustomStack<int> a3, int goal)
        {
            if (a3.GetLength() == goal)
            {
                return;
            }
            a1.PopPushTo(a3); // no worky ;-;
            a1.PopPushTo(a2);
            a3.PopPushTo(a2);
            a1.PopPushTo(a3);
            a2.PopPushTo(a1);
            a2.PopPushTo(a3);
            a1.PopPushTo(a3);

            Hanoi(a1, a2, a3, goal);
        }


        public void Test()
        {
            //testing speed over increments
            //for (int i = 10000; i <= 10000; i *= 10)
            //{
            //    int[] TestingArray = new int[i];
            //    Random rnd = new Random();
            //    for (int j = 0; j < TestingArray.Length; j++)
            //    {
            //        TestingArray[j] = 10000-j;
            //    }
            //    var timer = new Stopwatch();
            //    timer.Start();

            //   var test = Algorithm.treeSort(TestingArray);
            //    timer.Stop();
            //    Console.WriteLine("Time: " + timer.ElapsedTicks + " Size: " + i);
            //    //for (int k = 0; k < TestingArray.Length; k++)
            //    //    Console.WriteLine(TestingArray[k] + " ");
            //}
        }
    }
}
