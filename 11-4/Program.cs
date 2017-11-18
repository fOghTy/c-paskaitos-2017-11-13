using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var a = 1; a <= 10; a++)
            {
                Console.WriteLine(a);
            }
            if (a % 2 == 0)
            {
                Console.WriteLine("lyginis skaicius");
            }
        }
    }
}
