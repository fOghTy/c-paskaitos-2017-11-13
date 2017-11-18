using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite rezultata");
            var a = Convert.ToInt32(Console.ReadLine());

            if (a == 100)
            {
                Console.WriteLine("100");
            }
            else if (a >= 80)
            {
                Console.WriteLine("80-100");
            }
            else if (a >= 50)
            {
                Console.WriteLine("50-80");
            }
            else if (a >= 20)
            {
                Console.WriteLine("20-50");
            }
            else if (a < 20)
            {
                Console.WriteLine("< 20");
            }
        }
    }
}
