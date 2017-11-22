using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            var knyga1 = new Knyga(); // objektas
            knyga1.Pavadinimas = "Haris floperis";
            knyga1.Autorius = "Anonymous";
            knyga1.Metai = 1969;
            knyga1.PuslapiuSkaicius = 15;
            knyga1.Isvedimas();

            var knyga2 = new Knyga("Voldemorto nuotykiai", "Jis", 10, 1817);
            knyga2.Isvedimas();

            var knygos = new List<Knyga>
            {
                new Knyga("Kaip programuoti?", "Hackeris", 1000000, -1561),
                new Knyga("Anyksciu silas", "Wikipedia", 1500, 2000),
                new Knyga("Haris Poteris", "Rowling", 350, 2007)
            };

            foreach (var knyga in knygos)
            {
                knyga.Isvedimas();
            }
        }
    }
}
