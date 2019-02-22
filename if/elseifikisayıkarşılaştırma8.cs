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
            int sayi1, sayi2;
            Console.Write("1. sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi1 > sayi2)
            {
                Console.Write("{0} sayısı {1} sayısından büyüktür.", sayi1, sayi2);
            }
            else if (sayi1 < sayi2)
            {
                Console.Write("{0} sayısı {1} sayısından büyüktür.", sayi2, sayi1);
            }
            else
            {
                Console.Write("{0} sayısı ile {1} sayısı birbirine eşittir.", sayi1, sayi2);
            }
            Console.ReadKey(); 

        }
    }
}
