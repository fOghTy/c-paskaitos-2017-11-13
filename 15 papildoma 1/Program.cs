using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_papildoma_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();

            Console.WriteLine("Iveskite du skaicius");
            var a = Convert.ToInt32(Console.ReadLine)();
            var b = Convert.ToInt32(Console.ReadLine)();
            var plotas = a * b;
            var perimetras = (double)a + b;
            Console.WriteLine("{0} * {1} = {2}", plotas);
            Console.WriteLine("{0} + {1} = {2}", perimetras);

            // paprasyti vartotojo dvieju staciakampio krastiniu, parasyti metodus: suskaiciuoti plota; suskaiciuoti perimetra. Gautus atsakymus isvesti
        }
    }
}
