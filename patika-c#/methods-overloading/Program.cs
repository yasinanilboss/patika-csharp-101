using System;

namespace methods_overloading // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";
            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("başarılı");
                Console.WriteLine(outSayi);

            }
            else
            {
                Console.WriteLine("Başarısız");
            }
            Metotlar instance = new Metotlar();
            instance.Topla(4, 5, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);
            //Metot Aşırı Yükleme-Overloading


            int ifade = 999;
            instance.ekranaYazdir(Convert.ToString(ifade));
            instance.ekranaYazdir(ifade);
            //metot imzası 
            //metotAdi+parametre sayisi + parametre
            instance.ekranaYazdir("Ozcan", "Acar");

            Console.ReadLine();
        }
    }
    class Metotlar
    {

        public void Topla(int a, int b, out int toplam)
        {

            toplam = a + b;
        }
        public void ekranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void ekranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void ekranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }

    }
}