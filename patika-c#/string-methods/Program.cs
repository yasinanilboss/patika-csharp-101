using System;

namespace StringMetotları
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Merhaba, benim adim Yasin Anil Bostanci. Hoşgeldiniz!";
            string degisken2 = "Yasin Anil Bostanci";

            //Length
            Console.WriteLine(degisken.Length);

            //ToUpper-ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(string.Concat(degisken, " Haydi Başlayalim!"));

            //Compare - CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(string.Compare(degisken, degisken2, true));

            //Equals
            Console.WriteLine(string.Equals(degisken, degisken2));

            //Contains
            Console.WriteLine(degisken.Contains("Yasin Anil"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));
            Console.WriteLine(degisken.EndsWith("Bostanci"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("Yas"));
            Console.WriteLine(degisken.IndexOf("Anil"));
            Console.WriteLine(degisken.LastIndexOf('n'));

            //Insert
            Console.WriteLine(degisken.Insert(0, "Aaa, "));

            //PadLeft - PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(40));
            Console.WriteLine(degisken.Remove(30, 10));
            Console.WriteLine(degisken.Remove(0, 1));

            //Replace
            Console.WriteLine(degisken.Replace("Yasin", "Zeliş"));
            Console.WriteLine(degisken.Replace(' ', '*'));

            //Split
            Console.WriteLine(degisken.Split(' ')[3]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4, 6));


            Console.ReadLine();
        }
    }
}