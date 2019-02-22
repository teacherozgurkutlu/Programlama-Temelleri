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
            int sayi = 0;
            int toplam = 0;
            while (sayi % 2 == 0)
            {
                toplam = toplam + sayi;
                Console.Write("Sayi giriniz:");
                sayi = Convert.ToInt16(Console.ReadLine());
            }
            Console.Write("Girilen sayıların toplamı :" + toplam);
            Console.ReadKey();

        }
    }
}
