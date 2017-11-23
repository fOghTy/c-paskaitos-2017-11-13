using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Medis
{
    class Program
    {
        static void Main(string[] args)
        {
            var medis = new Medis("Azuolas", 50, 4.20);
            medis.Isvedimas();
            var programa = new Program();
            Console.WriteLine("Aukstis " + medis.cm());
            Console.WriteLine("Kada pasodinta: " + medis.kada());
        }
    }
}
