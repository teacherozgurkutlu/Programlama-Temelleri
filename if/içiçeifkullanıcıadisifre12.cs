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
            string kullanıcıadi, sifre;
            Console.Write("Kullanıcı adını giriniz : ");
            kullanıcıadi = Console.ReadLine();
            Console.Write("Şifrenizi giriniz       : ");
            sifre = Console.ReadLine();

            if (kullanıcıadi == "admin")
            {

                if (sifre == "1234")
                {
                    Console.Write("Programa hoş geldiniz");
                }
                else
                {
                    Console.Write("Şifreyi yanlış girdiniz");
                }
            }
            else
            {

                if (sifre == "1234")
                {
                    Console.Write("Kullanıcı adı yanlış girdiniz");
                }
                else
                {
                    Console.Write("Bilgiler uyuşmuyor");
                }
            }



            Console.ReadKey();

        }
    }
}
