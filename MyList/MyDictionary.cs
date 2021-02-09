using System;
using System.Collections.Generic;


namespace MyDictionary
{
    //burada kendi dictionary'miz için gerek bütün operasyonları oluşturmak için
    //bir sınıf oluşturuyoruz.
    class MyDictionary<TKey , TValue>
    {
        //burada TKey ve TValue tipinde, keys ve values adında bir array oluşturuyoruz.
        TKey[] keys;
        TValue[] values;

        //sonra onları bir constructor içinde new'liyoruz.
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        //burada yukarıda oluşturduğumuz array'lere bir veri ekleme metot'u oluşturuyoruz.
        public void Add(TKey key, TValue value)
        {

            //burada üstte oluşturduğumuz array'in elemanları uçmasın diye
            //geçici bir array oluşturup elemanlarımızı ona emanet ediyoruz.
            TKey[] tempKeys = keys;
            TValue[] tempValues = values;


            //burada ilk oluşturduğumuz TKey ve TValue arraylerini
            //kendi uzunluklarının 1 fazlasınca arttırıyoruz.
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];


            //burada for döngüsü yardımıyla tempArraylerimizdeki elemanları tek tek
            //yeni oluşturduğumuz eleman sayısı 1 arttırılmış arraylerimize veriyoruz.
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            //burada yeni arrayimizdeki sonuncu elemana main'den gelecek olan verilerin değerini veriyoruz.
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        //burada kendi dictionary'mizdeki bütün elemanları listelemek için bir metot oluşturuyoruz.
        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " " + values[i]);

            }
        }

        





    }
}
