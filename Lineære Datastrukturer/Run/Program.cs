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
                string Sekvens = "testing testing";

                CustomStack<char> Stack = new CustomStack<char>();
                
                foreach (char c in Sekvens)
                {
                    Stack.Push(c);
                }
                var testing = Stack.IsPalindrom();
                Console.WriteLine(testing);

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
