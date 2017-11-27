using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            var darbuotojas = new Darbuotojas("Dzonas", "Petruska", 25, 1, 550);
            darbuotojas.Isvedimas();
            Console.WriteLine();
            var policininkas = new Policininkas("Petras", "Jonuska", 30, 1, 650, 60, 20);
            policininkas.Isvedimas();
            Console.WriteLine();
            var medikas = new Medikas("Juozas", "Kalnas", 35, 1, 800, 5, 25);
            medikas.Isvedimas();
            Console.WriteLine();
        }
    }
}
