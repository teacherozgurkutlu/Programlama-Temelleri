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
            int nott;
            Console.Write("Öğrencinin notunu giriniz (0-100) : ");
            nott = Convert.ToInt16(Console.ReadLine());
            if ((nott >= 85) && (nott <= 100))
            {
                Console.Write("Beş");
            }
            else if ((nott >= 70) && (nott <= 84))
            {
                Console.Write("Dört");
            }
            else if ((nott >= 55) && (nott <= 69))
            {
                Console.Write("Üç");
            }
            else if ((nott >= 50) && (nott <= 54))
            {
                Console.Write("İki");
            }
            else if ((nott >= 0) && (nott <= 49))
            {
                Console.Write("Bir");
            }
            else
            {
                Console.Write("Hatalı bilgi girişi değer 0-100 arasında olmalı");
            }

            Console.ReadKey();

        }
    }
}
