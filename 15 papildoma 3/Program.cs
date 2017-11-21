using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_papildoma_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> atlyginimai = new List<double>();
            var programa = new Program();
            programa.Ivedimas(atlyginimai);
            Console.WriteLine("Maziausias atlyginimas: " + programa.MaziausiaAlga(atlyginimai));
            Console.WriteLine("Didziausias atlyginimas: " + programa.DidziausiaAlga(atlyginimai));
            Console.WriteLine("Vidutinis atlyginimas: " + programa.VidutineAlga(atlyginimai));
            Console.WriteLine("Daugiau uz vidurki: " + programa.DaugiauUzVidurki(atlyginimai));
            Console.WriteLine("Daugiau uz 1500: " + programa.KiekDaugiauUzX(atlyginimai, 1500));
        }

        public void Ivedimas(List<double> atlyginimai)
        {
            Console.WriteLine("Kiek atlyginimu norite ivesti?");
            var kiek = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine("Iveskite {0} skaiciu: ", i + 1);
                atlyginimai.Add(Convert.ToDouble(Console.ReadLine()));
            }
        }
        public void Isvedimas(List<double> atlyg)
        {
            foreach (var atl in atlyg)
            {
                Console.WriteLine("[{0}]", atl);
            }

            Console.WriteLine();
        }
        public double MaziausiaAlga(List<double> atlyginimai)
        {
            return atlyginimai.Min();
        }

        public double DidziausiaAlga(List<double> atlyginimai)
        {
            return atlyginimai.Max();
        }

        public double VidutineAlga(List<double> atlyginimai)
        {
            return atlyginimai.Average();
        }

        // randame kiek algų yra daugiau už vidurkį

        public int DaugiauUzVidurki(List<double> atlyginimai)
        {
            var vidurkis = VidutineAlga(atlyginimai);
            var kiekis = 0;

            foreach (var atlyginimas in atlyginimai)
            {
                if (atlyginimas > vidurkis)
                {
                    kiekis++;
                }
            }

            return kiekis;
        }

        // rasti kiek algų buvo virš 1500 €

        public int KiekDaugiauUzX(List<double> atlyginimai, double daugiauUz)
        {
            var kiekis = 0;

            foreach (var atlyg in atlyginimai)
            {
                if (atlyg > daugiauUz)
                {
                    kiekis++;
                }
            }

            return kiekis;
        }
    }
}
