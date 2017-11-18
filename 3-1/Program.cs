using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 4;
            var b = 5;
            var suma = a + b;
            var skirtumas = a - b;
            var sandauga = a * b;
            var dalmuo = a / b;

            Console.WriteLine("{0} + {1} = {2}", a, b, suma);
            Console.WriteLine("{0} - {1} = {2}", a, b, skirtumas);
            Console.WriteLine("{0} * {1} = {2}", a, b, sandauga);
            Console.WriteLine("{0} / {1} = {2}", a, b, dalmuo);

            // 2 budas

            var c = 6;
            var d = 4;

            Console.WriteLine("{0} + {1} = {2}", c, d, c + d);
            Console.WriteLine("{0} - {1} = {2}", c, d, c - d);
            Console.WriteLine("{0} * {1} = {2}", c, d, c * d);
            Console.WriteLine("{0} / {1} = {2}", c, d, c / d);
        }
    }
}
