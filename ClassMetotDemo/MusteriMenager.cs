using System;

namespace ClassMetotDemo
{
    class MusteriMenager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi : " + musteri.Adi + " " + musteri.SoyAdi);
        }


        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi : " + musteri.Adi + " " + musteri.SoyAdi);
        }


        
        


    }
}
