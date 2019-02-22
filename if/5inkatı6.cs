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
            if (sayi % 5 == 0)
            {
                Console.Write("Girdiğiniz sayı 5'in katıdır");
            }
            else
            {
                Console.Write("Girdiğiniz sayı 5'in katı değildir");
            }

            Console.ReadKey();

        }
    }
}
