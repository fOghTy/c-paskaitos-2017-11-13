using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite neigiama skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                while (a < 0)
                {
                    Console.WriteLine(a);
                    a++;

                }
            }
            else { Console.WriteLine("skaicius teigiamas"); }
        }
    }
}
