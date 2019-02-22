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
            Console.Write("Bir sayı giriniz :");
            sayi = Convert.ToInt16(Console.ReadLine());
            if (sayi % 2 == 1)
            {
                Console.Write("Girdiğiniz sayı tek bir sayıdır");
            }
            else
            {
                Console.Write("Girdiğiniz sayı çift bir sayıdır");
            }

            Console.ReadKey(); 

        }
    }
}
