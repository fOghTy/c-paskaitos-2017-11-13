using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Parduotuve
{
    class Parduotuve
    {
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public List<Preke> Prekes { get; private set; }

        public Parduotuve(string pavadinimas, string adresas)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Prekes = new List<Preke>();
            SugeneruotiPrekes();

            Console.WriteLine("1. Generuoti prekes?");
            Console.WriteLine("2. Suvesti prekes?");
            var pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    SugeneruotiPrekes();
                    break;
                case 2:
                    SuvestiPrekes();
                    break;
                default: SugeneruotiPrekes();
                    break;
            }
        }

        public Parduotuve(string pavadinimas, string adresas, List<Preke> prekes)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Prekes = prekes;
        }
        public void SugeneruotiPrekes()
        {
            var rnd = new Random();
            var kiekPrekiu = rnd.Next(1, 20);
            var sakinys = "Proin pellentesque accumsan egestas Mauris ultrices auctor quam sit amet feugiat Etiam sollicitudin vehicula hendrerit Vivamus ac lacus eget elit mattis laoreet sed sit amet est";
            var zodziai = sakinys.Split(' ');

            for (int i = 0; i < kiekPrekiu; i++)
            {
                var pavadinimas = zodziai[rnd.Next(zodziai.Length)];
                var kodas = rnd.Next(10000, 100000).ToString();
                var kaina = rnd.Next(50, 100);
                var savikaina = rnd.Next(1, 50);
                var kiekis = rnd.Next(1, 100);
                var preke = new Preke(pavadinimas, kodas, kaina, savikaina, kiekis);
                Prekes.Add(preke);
            }
        }

        public void Isvedimas()
        {
            Console.WriteLine("Pavadinimas: " + Pavadinimas);
            Console.WriteLine("Adresas: " + Adresas);
            Console.WriteLine("Prekiu kiekis: " + Prekes.Count);
            foreach (var preke in Prekes)
            {
                preke.Isvedimas();
            }

            Console.WriteLine("Skaiciavimai: ");
            Console.WriteLine("Visu prekiu kainu suma: " + KainuSuma());
            Console.WriteLine("Visu prekiu savikainu suma: " + SavikainuSuma());

            Console.WriteLine("Maziausias kiekis: ");
            MaziausiasKiekis().Isvedimas();
            var maziausiaskiekis = MaziausiasKiekis();
            maziausiaskiekis.Isvedimas();

        }

        public void SuvestiPrekes()
        {
            Console.WriteLine("Kiek prekiu suvesti?");
            var kiekSuvesti = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiekSuvesti; i++)
            {
                Console.WriteLine("{0}-oji Preke", i + 1);
                Console.Write("Pavadinimas: ");
                var pavadinimas = Console.ReadLine();
                Console.Write("Kodas: ");
                var kodas = Console.ReadLine();
                Console.Write("Kaina: ");
                var kaina = Convert.ToInt32(Console.ReadLine());
                Console.Write("Savikaina: ");
                var savikaina = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kiekis: ");
                var kiekis = Convert.ToInt32(Console.ReadLine());

                var preke = new Preke(pavadinimas, kodas, kaina, savikaina, kiekis);
                Prekes.Add(preke);
            }
        }

        public double KainuSuma()
        {
            var suma = 0.0;

        foreach (var preke in Prekes)
        {
            suma+= preke.Kaina;
        }

        return suma;
}

        public double SavikainuSuma()
        {

            var suma = 0.0;

        foreach (var preke in Prekes)

        {
            suma+= preke.Savikaina;
        }
              return suma;
            }
        public double Pajamos()
        {

            var pajamos = 0.0;

        foreach (var preke in Prekes)

        {
            pajamos= preke.Kaina * preke.Kiekis;
        }
              return pajamos;
            }

        public double BendrasPelnas()
        {

            var suma = 0.0;

        foreach (var preke in Prekes)

        {
            suma += preke.PelnasPardavusVisaKieki();
        }
              return suma;
        }

        public Preke MaziausiasKiekis()
        {

            var maziausias = Prekes[0];

        foreach (var preke in Prekes)
        {
                if(preke.Kiekis < maziausias.Kiekis)
                {
                    maziausias = preke;
                }
            }
              return maziausias;
        }

        public Preke PigiausiaPreke()
        {
            var pigiausia = Prekes.First();
            foreach (preke in Prekes)
        }
    }
}
