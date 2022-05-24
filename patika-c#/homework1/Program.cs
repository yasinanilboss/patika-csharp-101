using System;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Questions.Q1();
            Questions.Q2();
            Questions.Q3();
            Questions.Q4();
        }
    }

    class Questions
    {

        public static void Q1()
        {
            Console.WriteLine("Pozitif bir sayi giriniz:");
            int number = int.Parse(Console.ReadLine());

            int[] numbers = new int[number];
            Console.WriteLine("{0} adet pozitif sayi giriniz: ", number);
            for (int i = 0; i < number; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}. sayi: {1}", i + 1, numbers[i]);

            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine("Girdiğiniz sayilardan {0} bir çift sayidir.", numbers[i]);
                }

            }

        }

        public static void Q2()
        {

            Console.WriteLine("2 adet pozitif sayi giriniz: ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} adet pozitif sayi giriniz:", number1);
            int[] numbers = new int[number1];

            for (int i = 0; i < number1; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}. sayiniz: {1}", i + 1, numbers[i]);

            }
            foreach (var item in numbers)
            {
                if (item == number2 || item % number2 == 0)
                {
                    Console.WriteLine("Girdiğiniz {0} sayisi {1} ile eşit ya da tam bölendir.", item, number2);
                }
                else
                    Console.WriteLine("Girdiğiniz {0} sayisi {1} ile eşit ya da tam bölen değildir.", item, number2);

            }
        }

        public static void Q3()
        {
            Console.WriteLine("Pozitif bir sayi giriniz: ");

            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} sayi giriniz: ", number);

            string[] arr = new string[number];

            for (int i = 0; i < number; i++)
            {
                arr[i] = Console.ReadLine();
            }

            Console.WriteLine();
            int count = number - 1;
            while (count >= 0)
            {
                Console.Write(arr[count] + " ");
                count--;
            }

        }

        public static void Q4()
        {
            string str;
            Console.WriteLine("Cumle giriniz: ");
            str = Console.ReadLine();

            char[] charArray = str.ToCharArray();

            int len = charArray.Length - 1;
            int space = 0;

            while (len >= 0)
            {
                if (charArray[len] == 32)
                {
                    space++;
                }

                len--;

            }
            int word = space + 1;

            int letter = charArray.Length - space;
            Console.WriteLine("Harflerin sayisi {0} ... word count: {1}", letter, word);
        }
    }
}