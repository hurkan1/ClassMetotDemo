using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Add(Musteri musteri)
        {
            Console.WriteLine("----Müşteri Ekleme----");
            Console.WriteLine("Müşteri Kayıt: "+ musteri.Name+ " "+musteri.Surname);
            Console.WriteLine("Müşteri'yer verilen Id: " + musteri.Id);
            Console.WriteLine("Tebrikler! Müşteri kaydı tamamlandı: " + musteri.Name + " " + musteri.Surname+ " "+ musteri.Id);
        }

        public void List(Musteri musteri)
        {
            Console.WriteLine("----Müşteri Listeleme----");
            Console.WriteLine("Müşteri'nin Adı: " + musteri.Name);
            Console.WriteLine("Müşteri'nin Adı: " + musteri.Surname);
            Console.WriteLine("Müşteri'nin Yaşı: " + musteri.Age);
            Console.WriteLine("Müşteri'ye verilen Id: " + musteri.Id);
        }

        public void Del(Musteri musteri)
        {
            Console.WriteLine("----Müşteri Silme----");
            Console.WriteLine("Müşteri Silme: " + musteri.Name + " " + musteri.Surname);
            Console.WriteLine("Müşteri Id: " + musteri.Id);
            Console.WriteLine("Müşteri silme işlemi tamamlandı: " + musteri.Name + " " + musteri.Surname + " " + musteri.Id);
        }
    }
}
