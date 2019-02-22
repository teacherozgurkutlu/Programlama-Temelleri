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
            string sifre = "";
            while (sifre != "1234")
            {
                Console.Write("Şifre giriniz : ");
                sifre = Console.ReadLine();
            }

            Console.Write("Programa hoş geldiniz...");
            Console.ReadKey();

        }
    }
}
