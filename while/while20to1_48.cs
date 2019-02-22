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
            int sayi = 20;
            while (sayi > 0)
            {
                Console.WriteLine(sayi);
                sayi--;// sayi+=1 //sayi=sayi+1;
            }
            Console.ReadKey();

        }
    }
}
