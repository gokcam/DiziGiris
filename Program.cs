using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç adet sayı olduğunu giriniz");
            int sayiAdedi = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[sayiAdedi];

            for(int i=0;i<sayiAdedi;i++)
            {
                Console.Write("Lütfen {0}. sayiyi giriniz",i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());

            }
            int toplam =0;
            foreach (var sayi in sayiDizisi)
            {
                toplam+= sayi;

            }

            Console.WriteLine("Sayilarin ortalamasi ="+toplam/sayiAdedi);
        }
    }
}