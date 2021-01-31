using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);//30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);//999

            // int, decimal,flot,double,bool = değer tipler
            // array,class, interface=referans
            //bellekte iki tip yerimiz var stack ve heap
            //satck= sayi1=10 sayi2=30(değer tiplerin eklendiği yer)
            //heap 101/[10,20,30]-bellekten adres oluşturur
        }
    }
}
