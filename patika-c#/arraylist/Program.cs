using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList liste = new ArrayList();
            //liste.Add("Zehra");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add('F');

            // Arraylist icindeki verilere erisim
            //Console.WriteLine(liste[1]); // index tiple erisim

            //foreach (var item in liste)
            //    Console.WriteLine(item);

            Console.WriteLine("********** Add Range ***********");
            //AddRange
            string[] renkler = { "Sari", "Yesil", "Mavi", "Mor", "Pembe" };
            List<int> sayilar = new List<int>() { 1, 5, 32, 7, 34, 2, 6, 87 };

            //liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
                Console.WriteLine(item);

            //Sort
            Console.WriteLine("************** Sort ***********");
            liste.Sort();

            foreach (var item in liste)
                Console.WriteLine(item);

            // Binary Search
            Console.WriteLine("************** Binary Search ***********");
            Console.WriteLine(liste.BinarySearch(2)); //Girilen sayinin binary index'ini geri dondurur. Yoksa (-) eksi deger dondurur.

            //Reverse
            Console.WriteLine("************** Reverse ***********");
            liste.Reverse();

            foreach (var item in liste)
                Console.WriteLine(item);

            //Clear
            Console.WriteLine("************** Clear ***********");
            liste.Clear();  //Liste bos oldugu icin bisey yazmadi.
            foreach (var item in liste)
                Console.WriteLine(item);
        }
    }
}