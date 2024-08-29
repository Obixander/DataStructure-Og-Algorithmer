using Algorithms;
using DataStructures;
using Library;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Run
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                for (int i = 10; i <= 10; i *= 10)
                {
                    CustomList<int> test = new CustomList<int>(5);
                    for (int j = 0; j < test.Length()+1; j++)
                    {
                        test.Add(j, j);
                    }
                    var timer = new Stopwatch();
                    timer.Start();
                    test.RemoveAt(i - 1);
                    timer.Stop();
                    Console.WriteLine("Time: " + timer.ElapsedTicks + " Size: " + i);
                }

                CustomStack<int> Stack = new CustomStack<int>(2); // works
                Stack.Push(1);
                Stack.Push(2);
                Stack.Push(3);




                Console.ReadLine();
            }

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
