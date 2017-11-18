using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite sios dienos temperatura:");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            if (skaicius < 0)
            {
                Console.WriteLine("ziauriai salta");
            }
            else if (skaicius < 10)
            {
                Console.WriteLine("labai salta");
            }
            else if (skaicius < 20)
            {
                Console.WriteLine("salta");
            }
            else if (skaicius < 30)
            {
                Console.WriteLine("normali temperatura");
            }
            else if (skaicius < 40)
            {
                Console.WriteLine("karsta");
            }
            else if (skaicius > 40)
            {
                Console.WriteLine("visiskai degina");
            }
        }
    }
}
