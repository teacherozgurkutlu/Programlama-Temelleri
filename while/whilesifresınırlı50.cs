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
            int hak = 3;
            bool aktif = false;
            while (sifre != "1234" && hak > 0)
            {
                Console.Write("Şifre giriniz : ");
                sifre = Console.ReadLine();
                hak--;
                if (sifre == "1234")
                {
                    aktif = true;
                }
            }
            if (aktif == true)
            {
                Console.Write("Programa hoş geldiniz...");
            }
            else
            {
                Console.Write("Hakkınız bitti şifreyi bilemediniz");
            }

            Console.ReadKey();

        }
    }
}
