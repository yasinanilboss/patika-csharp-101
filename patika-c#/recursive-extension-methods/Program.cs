using System;

namespace recursive_extension_methods// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // rekürsif öz yinelemeli 
            //3*3*3*3
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;

            }
            Console.WriteLine(result);
            islemler instance = new islemler();

            Console.WriteLine(instance.Expo(3, 4));
            //extension metotlar
            string ifade = "Ozcan Acar";
            bool sonuc = ifade.Checkspaces();
            Console.WriteLine(sonuc);

            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = { 9, 3, 6, 2, 1, 5, 0 };
            dizi.sortArray();
            dizi.EkranaYazdir();
            int sayi = 5;
            Console.WriteLine(sayi.isEvenNumber());
            Console.WriteLine(ifade.getFirstCharacter());




        }
    }
    public class islemler
    {
        public int Expo(int sayi, int us)
        {
            if (us < 2)
            {
                return sayi;
            }

            return Expo(sayi, us - 1) * sayi;
        }

    }
    public static class Extension
    {
        public static bool Checkspaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("*", dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] sortArray(this int[] param)
        {
            Array.Sort(param);
            return param;

        }
        public static void EkranaYazdir(this int[] param)
        {
            foreach (int item in param)
            {
                Console.WriteLine(item);

            }
        }
        public static bool isEvenNumber(this int param)
        {
            return param % 2 == 0;
        }
        public static string getFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }

    }

}