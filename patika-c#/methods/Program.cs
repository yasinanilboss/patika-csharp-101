using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Kullanımı
            erisim_belirteci geri_donus_tipi metot_adi(parametreListesi/arguman)
            {
                Komutlar;
                return;
            }
            */
            int a = 50;
            int b = 60;
            int sonuc2 = Carp(a, b);
            Console.WriteLine(sonuc2);

            //metot class ını kullana bilmek için ornek e atama yaptık
            Metot ornek = new Metot();

            ornek.Yazdir(Convert.ToString(sonuc2));

            int sonuc3 = ornek.ArtırTopla(a, b);
            ornek.Yazdir(Convert.ToString(sonuc2));
            ornek.Yazdir(Convert.ToString("A ve B sayısının toplamı değişmedi: " + Convert.ToString(a + b)));

            int sonuc4 = ornek.RefArtır(ref a, ref b);
            ornek.Yazdir(Convert.ToString(sonuc4));
            ornek.Yazdir(Convert.ToString("Ref alındığı için A ve B sayısının toplamı değişti: " + Convert.ToString(a + b)));
        }
        static int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
    class Metot
    {
        public void Yazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public int ArtırTopla(int sayi1, int sayi2)
        {
            sayi1 += 1;
            sayi2 += 1;
            return sayi1 + sayi2;
        }
        //ArtırTopla ile RefArtır arasındaki fark ArtırTopla da  sayi 1 ve sayi iki sabit kaldı RefArtırda sayi 1 ve sayi 2 değişti
        public int RefArtır(ref int sayi1, ref int sayi2)
        {
            sayi1 += 2;
            sayi2 += 2;
            return sayi1 + sayi2;
        }
    }
}