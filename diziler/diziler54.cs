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
            string[] sebzeler = new string[5];

            for (int i = 0; i <= 4; i++)
            {
                sebzeler[i] = Console.ReadLine();
            }

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(sebzeler[i]);
            }


            Console.ReadKey();

        }
    }
}
