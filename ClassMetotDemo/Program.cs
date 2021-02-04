using System;
namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Müşteri dataları

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = ("Abel");
            musteri1.SoyAdi = ("Tesfaye");
            musteri1.Yas = 30;


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = ("Sabrina");
            musteri2.SoyAdi = ("Claudio");
            musteri2.Yas = 24;


            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = ("Bella");
            musteri3.SoyAdi = ("Hadid");
            musteri3.Yas = 24;



            //Musteri ekleme

            MusteriMenager musteriMenager = new MusteriMenager();
            musteriMenager.Ekle(musteri2);


            Console.WriteLine("-----------------------------------------------------------");


            //Musterileri Listeleme
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            

            Console.WriteLine("Bankadaki Mevcut Müşteriler: ");

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + "." + musteri.Adi + " " + musteri.SoyAdi);

            }

            Console.WriteLine("-----------------------------------------------------------");


            //Musteri silme
            musteriMenager.Sil(musteri3);


           



        }
    }
}
