using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety-veri türünü yazma zorunluluğu
            // kategoriEtiketi-değer tutucu,alias
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu ");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu ");
            }
            else
            {
                Console.WriteLine("değişmedi butonu ");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
