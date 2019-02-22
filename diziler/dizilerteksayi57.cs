using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0, sayi;

            int[] teksayilar = new int[10];

            do
            {
                Console.Write("Sayıyı giriniz : ");
                sayi = Convert.ToInt16(Console.ReadLine());
                if (sayi % 2 == 1)
                {
                    teksayilar[sayac] = sayi;
                    sayac++;
                }
            }

            while (sayac < 10);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}. tek sayı : {1}", i + 1, teksayilar[i]);
            }



            Console.ReadKey();

        }
    }
}
