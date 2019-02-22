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
            int yazili1, yazili2, ort;
            Console.WriteLine("Yazili1'i giriniz: ");

            yazili1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Yazili'2 i giriniz: ");

            yazili2 = Convert.ToInt16(Console.ReadLine());

            ort = (yazili1 + yazili2) / 2;

            if (ort >= 50)

                Console.WriteLine("geçti");

            else

                Console.WriteLine("kaldı");

            Console.ReadKey();

        }
    }
}
