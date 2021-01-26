using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Name = "Hürkan";
            musteri1.Surname = "Aydın";
            musteri1.Age = 30;
            musteri1.Id = "1";

            Musteri musteri2 = new Musteri();
            musteri2.Name = "Ayşe";
            musteri2.Surname = "Aydın";
            musteri2.Age = 40;
            musteri2.Id = "2";

            Musteri musteri3 = new Musteri();
            musteri3.Name = "Elif";
            musteri3.Surname = "Aydın";
            musteri3.Age = 50;
            musteri3.Id = "3";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Name + " " + musteri.Surname + " " + musteri.Age + " " + musteri.Id + " ");

                Console.WriteLine("--------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.List(musteri2);
            musteriManager.Del(musteri3);
        }
    }
}
