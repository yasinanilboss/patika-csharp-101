using System;

namespace array_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 23, 43, 45, 56, 12, 234, 546 };
            Console.WriteLine("Unsorted array");
            foreach (int item in numbers)
            {
                Console.WriteLine("{0} ", item);
            }
            Console.WriteLine();
            Console.WriteLine("Sorted array");
            Array.Sort(numbers);
            foreach (int item in numbers)
            {
                Console.WriteLine("{0} ", item);
            }

            Console.WriteLine();
            Console.WriteLine("Cleaned array");
            Array.Clear(numbers, 6, 1);
            foreach (int item in numbers)
            {
                Console.WriteLine("{0} ", item);
            }

            Console.WriteLine();
            Console.WriteLine("Reversed array");
            Array.Reverse(numbers);
            foreach (int item in numbers)
            {
                Console.WriteLine("{0} ", item);
            }

            Console.WriteLine();
            Console.WriteLine("IndexOf 234 in array");
            Console.WriteLine("{0} ", Array.IndexOf(numbers, 234));

            Console.WriteLine();
            Console.WriteLine("Resized array");

            int arraySize = numbers.Length;
            Array.Resize(ref numbers, arraySize + 1);
            numbers[arraySize] = 999;
            foreach (int item in numbers)
            {
                Console.WriteLine("{0} ", item);
            }

        }
    }

}


