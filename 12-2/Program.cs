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
            var skaicius = -4;

            while (skaicius < 0)
            {
                Console.WriteLine(skaicius); skaicius++;
            }
        }
    }
}
