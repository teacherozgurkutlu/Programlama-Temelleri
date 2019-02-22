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
            do
            {
                Console.Write("Şifreyi gir :");
                sifre = Console.ReadLine();
            } while (sifre != "dilara123");
            Console.Write("Programa hoş geldiniz!!!");
            Console.ReadKey();

        }
    }
}
