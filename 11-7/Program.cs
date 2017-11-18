using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;
            var a = Convert.ToInt32(Console.ReadLine());

            for (var a = 1; a < 100; a++)
            {
                suma += a;
            }

            Console.WriteLine("atsakymas: " + suma);
        }
    }
}
