using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pazymius:");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            var vidurkis = (double)(a + b + c) / 3;
            Console.WriteLine(Math.Round(vidurkis, 2));
        }
    }
}
