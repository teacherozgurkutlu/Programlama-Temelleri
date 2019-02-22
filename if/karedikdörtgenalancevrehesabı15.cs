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
            string sekil, islev;
            int kenar1, kenar2, cevre, alan;
            Console.Write("Şekli Seçiniz 1-Kare 2-Dikdörtgen : ");
            sekil = Console.ReadLine();
            Console.Write("Alan hesabıiçin A Çevre hesabı için C giriniz : ");
            islev = Console.ReadLine();

            if (sekil == "1")
            {
                Console.Write("1.Kenarı giriniz : ");
                kenar1 = Convert.ToInt16(Console.ReadLine());
                if (islev == "A")
                {
                    alan = kenar1 * kenar1;
                    Console.Write("Karenin alanı={0} cm2 dir", alan);
                }
                else
                {
                    cevre = 4 * kenar1;
                    Console.Write("Karenin cevresi={0} cm dir", cevre);
                }
            }
            else
            {
                Console.Write("1.Kenarı giriniz : ");
                kenar1 = Convert.ToInt16(Console.ReadLine());
                Console.Write("2.Kenarı giriniz : ");
                kenar2 = Convert.ToInt16(Console.ReadLine());
                if (islev == "A")
                {
                    alan = kenar1 * kenar2;
                    Console.Write("Dikdörtgenin alanı={0} cm2 dir", alan);
                }
                else
                {
                    cevre = 2 * kenar1 + 2 * kenar2;
                    Console.Write("Dikdörttgenin cevresi={0} cm dir", cevre);
                }

            }



            Console.ReadKey();

        }
    }
}
