using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Jusu vardas: ");
            var vardas = Console.ReadLine();
            Console.WriteLine("iveskite savo amziu:");
            var amzius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("jusu vardas yra {0}, jums yra {1} metai", vardas, amzius);
        }
    }
}
