using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri gmusteri = new GercekMusteri();
            gmusteri.Id = 1;
            gmusteri.MusteriNo = "12345";
            gmusteri.Adi = "Engin";
            gmusteri.Soyadi = "Demiroğ";
            gmusteri.TcNo = "2222222";

            TuzelMusteri tmusteri = new TuzelMusteri();
            tmusteri.Id = 2;
            tmusteri.MusteriNo = "54321";
            tmusteri.SirketAdi = "Kodlama.io";
            tmusteri.VergiNo = "15462486";

            Musteri gmusteri2 = new GercekMusteri();
            Musteri tmusteri2 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(gmusteri);
            musteriManager.Ekle(tmusteri);


        }
    }
}
