using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalısmaNotlarim
{
    internal class Struct
    {
        struct Futbolcu
        {
            public string isim;
            public string soyad;
            public string mevki;
            public int yas;
        }
        static void Main(string[] args)
        {
            Futbolcu nesne = new Futbolcu();
            Console.Write("Lütfen isminizi giriniz: ");
            nesne.isim = Console.ReadLine();
            Console.Write("Lütfen soyadınızı giriniz: ");
            nesne.soyad = Console.ReadLine();
            Console.Write("Lütfen mevkinizi giriniz: ");
            nesne.mevki = Console.ReadLine();
            Console.Write("Lütfen yaşınızı giriniz: ");
            nesne.yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nİsminiz : " + nesne.isim);
            Console.WriteLine("Soyadınız : " + nesne.soyad);
            Console.WriteLine("Mevkiniz : " + nesne.mevki);
            Console.WriteLine("Yaşınız : " + nesne.yas);
            Console.ReadLine();

        }
    }
}
