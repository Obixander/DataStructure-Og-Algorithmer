using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
namespace SumAfElementer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[] testing = new int[1000000];
                Random rnd = new Random();
                for (int i = 0; i < testing.Length; i++)
                {
                    testing[i] = rnd.Next(1, testing.Length);
                }
                var timer = new Stopwatch();
                timer.Start();
                var test = Sort(testing);
                timer.Stop();
                Console.WriteLine(timer.ElapsedTicks);
                
                //method call goes here'
                //matching(testing, testing2);
                Console.ReadLine();
            }
        }

        public static int[] Sort(int[] array) // array = n
        {
            int n = array.Length;
            for (int j = 0; j < n - 1; j++)
            {
                for (int i = 0; i < n - j - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                       //this entire part is super inefficient but the psuodocode given says to this and i disagree
                       var items =  Swap(array[i], array[i+1]);
                        var First = items.Item1;
                        var Second = items.Item2;
                        array[i] = First;
                        array[i + 1] = Second;
                    }
                }
            }
            return array;
        }

        public static (int, int) Swap(int First, int Second) // this is stupid
        {
            int temp = First;
            First = Second;
            Second = temp;
            return (First, Second);
        }

        public static List<string> matching(string[] firstArray, string[] secondArray)
        {
            var timer = new Stopwatch();
            timer.Start();
            List<string> result = new List<string>();
            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (firstArray[i] == secondArray[j])
                    {
                        result.Add(firstArray[i]);
                    }
                }
            }
            timer.Stop();
            Console.WriteLine(timer.ElapsedTicks);
            return result;
        }
        public static void RemoveByValue(string[] array, string value)
        {
            //RemoveByValue(testing, "9999999");

            var timer = new Stopwatch();
            timer.Start();
            int test = 0;
            List<int> list = new List<int>();
            foreach (string item in array)
            {
                if (item == value)
                {
                    list.Add(test);
                }
                test++;
            }
            foreach (int item in list)
            {
                string[] newArray = new string[array.Length - 1];

                if (item > 0)
                    Array.Copy(array, 0, newArray, 0, item);

                // Copy elements after the index
                if (item < array.Length - 1)
                    Array.Copy(array, item + 1, newArray, item, array.Length - item - 1);
                array = newArray;
            }
            timer.Stop();
            Console.WriteLine(timer.ElapsedTicks);
        }

        public static void RemoveAt(string[] array, int index)
        {
            var timer = new Stopwatch();
            timer.Start();

            string[] newArray = new string[array.Length - 1];

            if (index > 0)
                Array.Copy(array, 0, newArray, 0, index);

            // Copy elements after the index
            if (index < array.Length - 1)

                Array.Copy(array, index + 1, newArray, index, array.Length - index - 1);
            array = newArray;


            timer.Stop();
            Console.WriteLine(timer.ElapsedTicks);
        }

        public static bool Contains(string[] array, string value)
        {
            //Contains(testing, "9999999");

            var timer = new Stopwatch();
            timer.Start();
            foreach (string item in array)
            {
                if (item == value)
                {
                    timer.Stop();
                    Console.WriteLine(timer.ElapsedTicks);
                    return true;
                }
            }
            timer.Stop();
            Console.WriteLine(timer.ElapsedTicks);
            return false;
        }


        public static string Find(string[] array, int index)
        {
            var timer = new Stopwatch();
            timer.Start();
            var value = array[index];
            timer.Stop();
            Console.WriteLine(timer.ElapsedTicks);
            return value;
        }


        public static int Sum(int[] numbers)
        {
            //int[] numbers = new int[10000000];
            //for (int j = 0; j < numbers.Length; j++)
            //{
            //    numbers[j] = j;
            //}
            //var result = Sum(numbers);


            var timer = new Stopwatch();
            timer.Start();
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            timer.Stop();
            Console.WriteLine(timer.ElapsedTicks);
            return sum;
        }
    }
}
