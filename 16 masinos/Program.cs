using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_masinos
{
    class Program
    {
        static void Main(string[] args)
        {
            var automobilis = new Automobilis("Audi", "A8", 2018, 4.2, 420, 1000);

            automobilis.Isvedimas();

            var automobiliai = new List<Automobilis>
            {
                new Automobilis("Bmw", "760Li", 2018, 5.0, 399, 15),
                new Automobilis("Audi", "A8", 2016, 4.2, 420, 150),
                new Automobilis("Mbenz", "C63", 2015, 6.3, 450, 1500),
                new Automobilis("Subaru", "Forester", 2014, 2.5, 150, 150000),
            };


            var programa = new Program();
            programa.Isvedimas(automobiliai);

            var naujausias = programa.NaujausiasAuto(automobiliai);
            Console.WriteLine("Naujausias auto: ");
            naujausias.Isvedimas();

            var seniausias = programa.SeniausiasAuto(automobiliai);
            Console.WriteLine("Seniausias auto: ");
            seniausias.Isvedimas();

            var galingiausias = programa.DidziausiaGalia(automobiliai);
            Console.WriteLine("Galingiausias auto: ");
            galingiausias.Isvedimas();

            var maziausiai = programa.MaziausiaiKm(automobiliai);
            Console.WriteLine("Maziausiai nuvaziuota km: ");
            maziausiai.Isvedimas();
        }
        public void Isvedimas(List<Automobilis> automobiliai)
        {
            foreach (var auto in automobiliai)
            {
                auto.Isvedimas();
            }
        }

        public Automobilis NaujausiasAuto(List<Automobilis> automobiliai)
        {
            var laikinas = automobiliai.First();

            foreach (var auto in automobiliai)
            {

                if (auto.Metai > laikinas.Metai)
                {
                    laikinas = auto;
                }

            }
            return laikinas;
        }

        public Automobilis SeniausiasAuto(List<Automobilis> automobiliai)
        {
            var senis = automobiliai.Last();

            foreach (var auto in automobiliai)
            {

                if (auto.Metai < senis.Metai)
                {
                    senis = auto;
                }

            }
            return senis;
        }

        public Automobilis DidziausiaGalia(List<Automobilis> automobiliai)
        {
            var galingiausias = automobiliai.First();

            foreach (var auto in automobiliai)
            {

                if (auto.Galia > galingiausias.Galia)
                {
                    galingiausias = auto;
                }


            }
            return galingiausias;
        }

        public Automobilis MaziausiaiKm(List<Automobilis> automobiliai)
        {
            var maziausiai = automobiliai.First();

            foreach (var auto in automobiliai)
            {
                if (auto.Rida < maziausiai.Rida)
                {
                    maziausiai = auto;
                }

            }
            return maziausiai;
        }
    }
}
