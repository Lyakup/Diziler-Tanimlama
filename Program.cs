using System;

namespace Diziler_Tanimlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] renkler = new string[5];

            string[] hayvanlar = { "Kedi", "Maymun", "Zürafa" };

            int[] dizi;
            dizi = new int[5];

            //Dizilere Değer Atama Ve Erişim
            renkler[0] = "Yeşil";
            dizi[3] = 12;

            Console.WriteLine(renkler[0]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(hayvanlar[2]);
            */

            //Döngülerle Dizi Kullanımı

            //N tane Sayının ortalamasını hesaplayan program
            Console.WriteLine("Dizinin Eleman Sayısını Giiniz");
            int diziUzunluk = int.Parse(Console.ReadLine());

            int[] sayiDizisi = new int[diziUzunluk];

            for (int i = 0; i < diziUzunluk; i++)
            {
                Console.Write("Lürfen {0}. sayıyı girin: ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }

            Console.WriteLine("Ortalama: " + toplam / diziUzunluk);
        }
    }
}
