using Algorithms;
using CustomDataStructures;
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

                CustomLinkedList<int> Testing = new();

                Testing.Add(1);
                Testing.Add(2);
                Testing.Add(3);
                Testing.Add(4);
                Testing.Remove(3);




            }
        }

        //public static void IntervalPrinting(CustomSequence<string> sequence)
        //{
        //    Console.WriteLine(sequence.Current());
        //    Thread.Sleep(500);
        //    for (int i = 0; i < sequence.GetLength()-1; i++)
        //    {
        //        Console.WriteLine(sequence.Next());
        //        Thread.Sleep(500);
        //    }
        //    for (int i = 0; i < sequence.GetLength() - 1; i++)
        //    {
        //        sequence.previous();
        //    }

        //}

        //public static void Hanoi(CustomStack<int> a1, CustomStack<int> a2, CustomStack<int> a3, int goal)
        //{

        //    //CustomSequence<string> sequence = new CustomSequence<string>();

        //    //sequence.Add("F");
        //    //sequence.Add("I");
        //    //sequence.Add("L");
        //    //sequence.Add("O");

        //    //while (true)
        //    //{
        //    //    IntervalPrinting(sequence);
        //    //    Console.WriteLine("---");
        //    //    sequence.Reverse();
        //    //    IntervalPrinting(sequence);
        //    //    Console.WriteLine("---");
        //    //}


        //    //CustomStack<int> a1 = new CustomStack<int>();
        //    //CustomStack<int> a2 = new CustomStack<int>();
        //    //CustomStack<int> a3 = new CustomStack<int>();

        //    //a1.Push(4);
        //    //a1.Push(3);
        //    //a1.Push(2);
        //    //a1.Push(1);

        //    //Hanoi(a1, a2, a3, a1.GetLength());

        //    MoveDisk(goal, a1, a3, a2);
        //}

        //public static void MoveDisk(int n, CustomStack<int> source, CustomStack<int> destination, CustomStack<int> auxiliary)
        //{
        //    if (n == 1) //base call
        //    {
        //        source.PopPushTo(destination);
        //        return;
        //    }

        //    //moves as many as it can to the auxiliary
        //    source.PopPushTo(destination);
        //    destination.PopPushTo(auxiliary);
        //    MoveDisk(n- 1, source, auxiliary, destination);

        //   source.PopPushTo(destination);

        //    auxiliary.PopPushTo(source);
        //    source.PopPushTo(destination);
        //    MoveDisk(n - 1, auxiliary, destination, source);

        //}

        //

//        CustomSequence<string> sequence = new CustomSequence<string>();
//        sequence.Add("F");
//                sequence.Add("I");
//                sequence.Add("L");
//                sequence.Add("O");

//               sequence.Reverse();
//                while (true)
//                {
//                        Console.WriteLine(sequence.Current());
//                    Thread.Sleep(500);
//                    for (int i = 0; i<sequence.Length() -1; i++)
//                    {  
//                        Console.WriteLine(sequence.Next());
//                        Thread.Sleep(500);
//                    }
//                    for (int i = 0; i<sequence.Length()-1; i++)
//                    {
//                        sequence.previous();
//                    }
//Console.WriteLine("---");
//Thread.Sleep(500);
//                }
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
