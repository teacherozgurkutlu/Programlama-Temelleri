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
            int yas;
            string cinsiyet;
            Console.Write("Cinsiyetinizi giriniz (e/k): ");
            cinsiyet = Console.ReadLine();
            Console.Write("Yaşınızı giriniz : ");
            yas = Convert.ToInt16(Console.ReadLine());
            if ((cinsiyet == "e") && (yas >= 20))
            {
                Console.Write("Askere gidebilirsin");

            }
            else
            {
                if (cinsiyet == "k")
                {
                    Console.Write("Türkiyede sadece erkekler askere gidiyor");
                }
                else
                {
                    Console.Write("Yaşın küçük olduğu için daha askere gidemezsin");
                }

            }


            Console.ReadKey();

        }
    }
}
