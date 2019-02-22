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
            Console.Write("Ünlü şairimiz Mehmet Akif'in soyadı nedir?\nCevabınız :");
            string cevap = Console.ReadLine();
            if (cevap == "ersoy")
            {
                Console.Write("Tebrikler bu sorumuza doğru cevap verdiniz...");
            }
            else
            {
                Console.WriteLine("Malesef yanlış cevap");
            }
            Console.ReadKey();

        }
    }
}
