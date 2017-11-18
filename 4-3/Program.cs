using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite betkoki skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(skaicius * skaicius);
        }
    }
}
