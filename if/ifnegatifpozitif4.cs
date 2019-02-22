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
            int sayi;
            Console.Write("Lütfen bir sayı giriniz: ");
            sayi = Convert.ToInt16(Console.ReadLine());
            if (sayi < 0)
            {
                Console.Write("Girdiğiniz sayı negatiftir");
            }
            else
            {
                Console.Write("Girdiğiniz sayı pozitiftir");
            }

            Console.ReadKey();

        }
    }
}
