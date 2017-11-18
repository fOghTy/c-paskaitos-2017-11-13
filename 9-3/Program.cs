using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skaicius pasirinktas");
            var a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                Console.WriteLine(a == a);
                break;
                case 2:
                    Console.WriteLine(a > a);
                    break;
            default:
                Console.WriteLine("nelygus");
                break;
        }

        }
    }
}
