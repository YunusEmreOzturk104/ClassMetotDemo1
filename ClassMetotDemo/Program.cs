using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Yunus Emre Öztürk";
            musteri1.Bakiye = 1500;
            musteri1.Id = 123;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "İbrahim Çelik";
            musteri2.Bakiye = 2500;
            musteri2.Id = 354;

            
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Bilgi(musteri1);
            Console.WriteLine("---");
            musteriManager.Ekle(musteri1);
            Console.WriteLine("---");
            musteriManager.Sil(musteri1);
            Console.WriteLine("**************");
            musteriManager.Bilgi(musteri2);
            Console.WriteLine("---");
            musteriManager.Ekle(musteri2);
            Console.WriteLine("---");
            musteriManager.Sil(musteri2);
            Console.WriteLine("---");





        }
    }
}
