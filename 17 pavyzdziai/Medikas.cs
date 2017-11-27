using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_pavyzdziai
{
    class Medikas : Darbuotojas
    {
        public int IsgelbetaGyvybiu { get; private set; }
        public int NuveztaLigoniu { get; private set; }

        public Medikas(string vardas, string pavarde, int amzius, double alga, double etatas, int isgelbetagyvybiu, int nuveztaligoniu)
            : base(vardas, pavarde, amzius, alga, etatas)
        {
            IsgelbetaGyvybiu = isgelbetagyvybiu;
            NuveztaLigoniu = nuveztaligoniu;
        }

        public void Isvedimas()
        {
            base.Isvedimas();
            Console.WriteLine("Isgelbeta Gyvybiu: " + IsgelbetaGyvybiu);
            Console.WriteLine("Nuvezta Ligoniu: " + NuveztaLigoniu);
            Console.WriteLine();
        }
    }
}
