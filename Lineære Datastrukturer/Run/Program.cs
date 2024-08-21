using Algorithms;
using Library;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace Run
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //testing speed over increments
                for (int i = 10; i <= 1000000000; i *= 10)
                {
                    int[] TestingArray = new int[i];
                    Random rnd = new Random();
                    for (int j = 0; j < TestingArray.Length; j++)
                    {
                        TestingArray[j] = rnd.Next(1, 101);
                    }
                    var timer = new Stopwatch();
                    timer.Start();
                    var Tree = Algorithm.InsertSortFast(TestingArray);
                    timer.Stop();
                    Console.WriteLine("Size: " + i + " Time: " + timer.ElapsedTicks);
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}
