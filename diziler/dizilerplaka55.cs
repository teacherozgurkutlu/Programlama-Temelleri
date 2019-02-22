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
            string[] plaka = new string[5];
            int kod;
            plaka[0] = "Adana";
            plaka[1] = "Adıyaman";
            plaka[2] = "Afyon";
            plaka[3] = "Ağrı";
            plaka[4] = "Amasya";
            Console.Write("Lütfen plaka kodunu giriniz :");
            kod = Convert.ToInt16(Console.ReadLine());
            Console.Write("Girdiğiniz plaka kodu {0}'a aittir ", plaka[kod - 1]);
            Console.ReadKey(); 

        }
    }
}
