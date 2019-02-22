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
            string sifre;
            int a = 1;
            do
            {
                Console.Write("Şifreyi gir :");
                sifre = Console.ReadLine();
                if (sifre == "dilara123")
                {
                    break;
                }

            } while (a == 1);
            Console.Write("Programa hoş geldiniz!!!");
            Console.ReadKey();

        }
    }
}
