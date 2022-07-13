using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Cep Telefonu";
            urun1.Ozellik = "Dokunmatik";
            urun1.Fiyati = 11000;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Tablet";
            urun2.Ozellik = "Dokunmatik";
            urun2.Fiyati = 1500;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Laptop";
            urun3.Ozellik = "Dizüstü";
            urun3.Fiyati = 15000;

            //Console.WriteLine(urun1.UrunAdi + " " + urun1.Ozellik + " " + urun1.Fiyati);
            Urun[] urunler = new Urun[] {urun1, urun2, urun3 };
            
            //forach
            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün Adı : " + urun.UrunAdi + " // " + "Ürün Fiyatı : "+ urun.Fiyati);
            }

          

        }

            class Urun
        {
            public string UrunAdi { get; set; }
            public string Ozellik { get; set; }
            public int Fiyati { get; set; }
        }

        

    } 
}
