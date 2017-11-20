using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite du skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            if (a > b || a == 0)
            {
                Console.WriteLine("pirmas skacius didesnis arba lygus 0");
            }
            if (b > a || b == 5)
            {
                Console.WriteLine("antras sakicius didesnis uz pirma arba lygus 5");
            }
            if (a > b && a == 20)
            {
                Console.WriteLine("ar pirmas skaicius yra didesnis uz antraji ir yra lygus 20");
            }
            if (b > a && b < 100)
            {
                Console.WriteLine("ar antras skaicius yra didesnsi uz pirmaji ir yra mazesnis nei 100");
            }
        }
    }
}
