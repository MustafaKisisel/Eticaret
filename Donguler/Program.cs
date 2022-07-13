using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] urunler = new string[] { "cepTelefonu", "tablet", "bilgisayar" };

            //for dongüsü
            for (int i = 0; i < urunler.Length; i+=1)
            {
                Console.WriteLine(urunler[i]);
            }
            Console.WriteLine("sayfa bitti");

            //foreach dongüsü
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun);
            }
        }
    }
}
