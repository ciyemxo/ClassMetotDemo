using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //burada kendi oluşturduğumuz custom dictionary'mizi çağırıp new'liyoruz.
            MyDictionary<int, string> winxPerileri = new MyDictionary<int, string>();

            //burada MyDictionary.cs'de oluşturduğumuz Add metotunu çağırıp,
            //ne eklemek istediğimizi belirtip (winxPerileri), bunun için gereken veriyi ekliyoruz (1, "bloom").
            winxPerileri.Add(1, "bloom");
            winxPerileri.Add(2, "stella");
            winxPerileri.Add(3, "flora");
            winxPerileri.Add(4, "techna");

            //burada ise MyDictionary.cs'de oluşturduğumuz listeleme metotunu çağırıyoruz.
            winxPerileri.List();
        }
    }
}
