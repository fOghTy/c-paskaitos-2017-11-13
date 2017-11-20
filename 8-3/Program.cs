using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite triju egzaminu rezulatus");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            var vidurkis = (double)(a + b + c) / 3;

            if (vidurkis >= 8 && vidurkis <= 10)
            {
                Console.WriteLine(vidurkis + "8-10");
            }
            else if (vidurkis >= 5 && vidurkis < 8)
            {
                Console.WriteLine(vidurkis + "5-8");
            }
            else if (vidurkis < 5)
            {
                Console.WriteLine(vidurkis + "< 5");
            }
        }
    }
}
