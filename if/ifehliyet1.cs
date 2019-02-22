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
            Console.Write("Lütfen yaşınızı giriniz : ");
            yas = Convert.ToInt16(Console.ReadLine());
            if (yas >= 18)
            {
                Console.Write("Ehliyet alabilirsiniz");
            }
            else
            {
                Console.Write("Ehliyet almak için yaşınız küçük");
            }

            Console.ReadKey();

        }
    }
}
