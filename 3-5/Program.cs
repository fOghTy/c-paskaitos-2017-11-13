using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5 * 0);
            Console.WriteLine(5 * 1);
            Console.WriteLine(5 * 2);
            Console.WriteLine(5 * 3);
            Console.WriteLine(5 * 4);
            Console.WriteLine(5 * 5);
            Console.WriteLine(5 * 6);
            Console.WriteLine(5 * 7);
            Console.WriteLine(5 * 8);
            Console.WriteLine(5 * 9);
            Console.WriteLine(5 * 10);

            // 2 budas

            var skaicius = 5;
            var daugiklis = 0;

            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
        }
    }
}
