using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //değişken tanımlama kısmı
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            //clas tanımlamak için
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //var ya da Urun diyebiliriz.
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------");
            }
            Console.WriteLine("---------------Metodlar-----------");
            //instance-örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 12,10);
            sepetManager.Ekle2("Elma", "yeşil elma", 15,9);
            sepetManager.Ekle2("Karpuz", "diyarbakır karpuzu", 8,8);
        }
    }
}

