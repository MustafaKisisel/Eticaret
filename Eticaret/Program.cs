using System;

namespace Eticaret
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32;
            double faizOrani = 1.45;
            bool girisYapildiMi = true;
            double dolarDun = 1.45;
            double dolarBugun = 1.45;

            //Dolar kuru kontrol
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Dolar Düştü");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Dolar Yükseldi");
            }
            else
            {
                Console.WriteLine("Dolar Aynı");
            }
           
            //Giriş Yapıldı mı?
            if (girisYapildiMi == true)
            {
                Console.WriteLine("Giriş Yapıldı");
            }
            else
            {
                Console.WriteLine("Giriş Yapılmadı!");
            }

            Console.WriteLine("Kategori Adı : " + kategoriEtiketi + " " + "Öğrenci Sayısı : " + ogrenciSayisi + " " + "Faiz Oranı : " + faizOrani);
            
            
        }
    }
}
