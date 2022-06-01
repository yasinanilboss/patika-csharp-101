using System;
using System.Collections.Generic;

namespace generic_lists
{
    class Program
    {

        static void Main(string[] args)
        {
            //List<T> class
            //System.Collecions.Generic
            // T-> object turundedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);


            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kirmizi");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sari");
            renkListesi.Add("Yesil");


            //Count
            Console.WriteLine("Sayi listesi = " + sayiListesi.Count);
            Console.WriteLine("Renk listesi = " + renkListesi.Count);

            //foreach ve List.ForEach ile elemanlara erisim
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);


            Console.WriteLine();

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            Console.WriteLine();


            //Listeden eleman cikarma

            //Elemani bul ve cikar
            sayiListesi.Remove(4);
            renkListesi.Remove("Yesil");

            //listenin verilen numarali matrisindeki elemani cikar
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste icerisinde arama
            if (sayiListesi.Contains(10))
                Console.WriteLine("10 liste icerisinde bulundu.");

            //Eleman ile index'e erisme
            Console.WriteLine(renkListesi.BinarySearch("Sari"));

            Console.WriteLine();
            //Diziyi List'e cevirme
            string[] hayvanlar = { "Kedi", "Fare", "Bal porsugu" };
            List<String> hayvanlarList = new List<string>(hayvanlar);
            hayvanlarList.ForEach(hayvan => Console.WriteLine(hayvan));

            //Listeyi nasil temizleriz
            hayvanlarList.Clear();

            Console.WriteLine();

            //List icerisinde nesne tutmak
            List<Users> usersList = new List<Users>();
            Users user1 = new Users();
            Users user2 = new Users();

            user1.Isim = "Ayse";
            user1.Soyisim = "Yardar";
            user1.Yas = 25;

            user2.Isim = "Metin";
            user2.Soyisim = "Korkak";
            user2.Yas = 30;

            usersList.Add(user1);
            usersList.Add(user2);

            List<Users> newList = new List<Users>();
            newList.Add(new Users()
            {
                Isim = "Yasin Anil",
                Soyisim = "Bostanci",
                Yas = 31
            });

            foreach (Users user in usersList)
            {
                Console.WriteLine("Kullanici Adi: " + user.Isim);
                Console.WriteLine("Kullanici Soyisim: " + user.Soyisim);
                Console.WriteLine("Kullanici Yas: " + user.Yas);
            }
        }
    }
    public class Users
    {
        string isim;
        string soyisim;
        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}