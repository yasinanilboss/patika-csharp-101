using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Questions.Q1();
            Questions.Q2();
            Questions.Q3();

        }

    }

    class Questions
    {
        public static void Q1()
        {
            ArrayList primeList = new ArrayList();
            ArrayList nonPrimeList = new ArrayList();
            Console.WriteLine("Sayilari giriniz");

            for (int i = 0; i < 20; i++)
            {
                string input = Console.ReadLine();
                int value;

                if (int.TryParse(input, out value) && value >= 0)
                {
                    if (value == 1 || value == 2)
                    {
                        primeList.Add(value);
                    }
                    else
                    {
                        bool isPrime = true;
                        for (int j = 2; j < (value / 2) + 1; j++)
                        {
                            if (value % j == 0)
                            {
                                isPrime = false;
                                nonPrimeList.Add(value);
                                break;
                            }
                        }
                        if (isPrime)
                            primeList.Add(value);
                    }
                }
                else
                {
                    Console.WriteLine("Sembol veya 0'dan kucuk sayi girdiniz. Program sonlandiriliyor.");
                    Environment.Exit(0);
                }
            }

            nonPrimeList.Sort();
            nonPrimeList.Reverse();
            primeList.Sort();
            primeList.Reverse();

            Console.WriteLine("******* Prime List *********");
            int sum1 = 0;
            foreach (var item in primeList)
            {
                sum1 += (int)item;
                Console.WriteLine(item);
            }

            Console.WriteLine("******* Prime List Count *********");
            Console.WriteLine(primeList.Count);
            Console.WriteLine("******* Prime List Average *********");
            Console.WriteLine(sum1 / primeList.Count);

            /////////////////////////////////////////////////////////////////

            Console.WriteLine("******* non-Prime List *********");
            int sum2 = 0;
            foreach (var item in nonPrimeList)
            {
                sum2 += (int)item;
                Console.WriteLine(item);
            }

            Console.WriteLine("******* non-Prime Count *********");
            Console.WriteLine(nonPrimeList.Count);
            Console.WriteLine("******* non-Prime List Average *********");
            Console.WriteLine(sum2 / primeList.Count);
        }

        public static void Q2()
        {
            int size = 20;
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            int[] minArr = new int[3] { arr[0], arr[1], arr[2] };

            Array.Reverse(arr);

            int[] maxArr = new int[3] { arr[0], arr[1], arr[2] }; ;


            Console.WriteLine("******** Min Array **********");
            int sum1 = 0;
            for (int i = 0; i < minArr.Length; i++)
            {
                Console.WriteLine(minArr[i]);
                sum1 += minArr[i];
            }
            Console.WriteLine("******** Min Array Sum **********");
            Console.WriteLine(sum1);
            Console.WriteLine("******** Min Array Average**********");
            Console.WriteLine(sum1 / minArr.Length);

            ////////// **************************************************** /////////////////////////////

            Console.WriteLine("******** Max Array **********");
            int sum2 = 0;
            for (int i = 0; i < maxArr.Length; i++)
            {
                Console.WriteLine(maxArr[i]);
                sum2 += maxArr[i];
            }
            Console.WriteLine("******** Min Array Sum **********");
            Console.WriteLine(sum2);
            Console.WriteLine("******** Max Array Average**********");
            Console.WriteLine(sum2 / maxArr.Length);
        }

        public static void Q3()
        {
            List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            string sentece = Console.ReadLine();
            string t = "";

            for (int i = 0; i < sentece.Length; i++)
            {
                if (vowels.Contains(sentece[i]))
                {
                    t += sentece[i];
                }
            }

            char[] characters = t.ToCharArray();

            Array.Sort(characters);

            for (int i = 0; i < characters.Length; i++)
            {
                Console.WriteLine(characters[i]);
            }
        }
    }
}