using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite gauta pazymi");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            if (skaicius == 10)
            {
                Console.WriteLine("puikiai");
            }
            else if (skaicius <= 2 )
            {
                Console.WriteLine("labai blogai");
            }
            else if (skaicius <= 4)
            {
                Console.WriteLine("prastai");
            }
            else if (skaicius <= 7)
            {
                Console.WriteLine("patenkinamai");
            }
            else if (skaicius <= 9)
            {
                Console.WriteLine("labai gerai");
            }
        }
    }
}
