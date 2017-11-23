using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Medis
{
    class Medis
    {
        public string Rusis { get; private set; }
        public int Amzius { get; private set; }
        public double Aukstis { get; private set; }

        public Medis(string rusis, int amzius, double aukstis)
        {
            Rusis = rusis;
            Amzius = amzius;
            Aukstis = aukstis;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Medzio rusis {0} amzius {1] aukstis {2}", Rusis, Amzius, Aukstis);
            Console.WriteLine();
        }

        public double cm()
        {
            var aukstis = Aukstis * 100;
            return aukstis;
        }
        public int kada()
        {
            var laikas = 2017 - Amzius;
            return laikas;
        }
    }
}
