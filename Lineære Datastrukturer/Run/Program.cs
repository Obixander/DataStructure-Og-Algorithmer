using Algorithms;
using System.Diagnostics;
using System.Numerics;

namespace Run
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                int[] TestArray = new int[100000];
                Random rnd = new Random();

                for (int i = 0; i < TestArray.Length; i++)
                {
                    TestArray[i] = rnd.Next(1,1001);
                }

                var timer = new Stopwatch();
                timer.Start();

                int[] test2 = Algorithm.SelectionSort(TestArray);

                timer.Stop();
                Console.WriteLine(timer.ElapsedTicks);
                Console.WriteLine();

                foreach (int i in test2)
                {
                   //Console.WriteLine(i);
                }

                Console.ReadLine();
            }
        }
    }
}
