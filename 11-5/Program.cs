using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite reziu pradzia ir pabaiga");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            if (a < b)
            {
            for (int i=a; i < b; a++)
                {
                    Console.WriteLine(a + " " + (a * a ));
                }
            }
        }
    }
}
