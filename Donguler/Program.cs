using System;

namespace Donguler
{

    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "Yazılım Geliştirici YEtiştirme Kampı";
            //string kurs2 = "Programlamaya başlangıç için temel kurs";
            //string kurs3 = "Java";

            //arrayde tutmak daha mantıklı
            string[] kurslar = new string[] { "Yazılım Geliştirici YEtiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java",
            "Python"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti----------------");
            //kurs-alias
            //dizileri kolay dolaşmak için foreach kullanabiliriz.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu-footer");
        }
    }
}
