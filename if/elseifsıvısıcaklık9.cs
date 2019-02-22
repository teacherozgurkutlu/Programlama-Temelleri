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
            int x;
            Console.Write("Suyun sıcaklık değerini giriniz : ");
            x = Convert.ToInt16(Console.ReadLine());
            if (x >= 100)
            {
                Console.Write("Gaz");
            }
            else if (x > 0)
            {
                Console.Write("Sıvı");
            }
            else
            {
                Console.Write("Katı");
            }

            Console.ReadKey();

        }
    }
}
