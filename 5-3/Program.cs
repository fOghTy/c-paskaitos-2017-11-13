using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            if (skaicius < 0 )
            {
                Console.WriteLine("Rekimas");
            }
            if (skaicius > 0)
            {
                Console.WriteLine("Sveikinimai");
            }
            if (skaicius % 2 == 0)
            {
                Console.WriteLine("Lyginis");
            }
            if (skaicius % 4 == 0)
            {
                Console.WriteLine("Dalinasi is 4");
            }
            if (skaicius > 10)
            {
                Console.WriteLine("Didesnis nei 10");
            }
        }
    }
}
