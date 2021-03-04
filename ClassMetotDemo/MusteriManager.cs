using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Eklenen Müşteri : " + musteri.Ad);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("{0} id'li {1} müşteri silindi ", musteri.Id, musteri.Ad);
        }
        public void Bilgi(Musteri musteri)
        {
            Console.WriteLine("Müşteri Adi:" + musteri.Ad);
            Console.WriteLine("Müşterinin Bakiye Durumu: " + musteri.Bakiye);
            Console.WriteLine("Müşterinin Id: " + musteri.Id);
        }
    }
}
