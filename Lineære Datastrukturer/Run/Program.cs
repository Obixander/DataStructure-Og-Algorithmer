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
                for (int i = 10000; i <= 10000; i *= 10)
                {
                    int[] TestingArray = new int[i];
                    Random rnd = new Random();
                    for (int j = 0; j < TestingArray.Length; j++)
                    {
                        TestingArray[j] = 10000-j;
                    }
                    var timer = new Stopwatch();
                    timer.Start();

                   var test = Algorithm.treeSort(TestingArray);
                    timer.Stop();
                    Console.WriteLine("Time: " + timer.ElapsedTicks + " Size: " + i);
                    //for (int k = 0; k < TestingArray.Length; k++)
                    //    Console.WriteLine(TestingArray[k] + " ");

                }
                Console.ReadLine();
            }
        }
    }
}
