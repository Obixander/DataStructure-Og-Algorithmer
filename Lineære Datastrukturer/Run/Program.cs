using Algorithms;
using Library;
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
                int counter = 0;
                for (int i = 99999; i >= 0; i--)
                {
                    TestArray[counter] = i;
                    counter++;
                }

                var timer = new Stopwatch();
                timer.Start();


                var item = Algorithm.TreeSort(TestArray);



                timer.Stop();
                Console.WriteLine(timer.ElapsedTicks);
                Console.WriteLine();

               


                Console.ReadLine();
            }
        }
    }
}
