using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> skaiciai = new List<int>();

            var rnd = new Random();  // atsitiktiniu skaiciu generavimui

            var kiekSugenertuoti = rnd.Next(1, 101); // [1-100]

            for (int i = 0; i < kiekSugenertuoti; i++)
            {
                // generuojam atsitiktini skaiciu ir ji dedam i sarasa
                skaiciai.Add(rnd.Next(1, 101));

                // isvedam ideta skaiciu
                Console.WriteLine(skaiciai[i] + " ");
            }

            Console.WriteLine("maziausias skaicius: " + skaiciai.Min());
            Console.WriteLine("didziausias skaicius: " + skaiciai.Max());
            Console.WriteLine("vidurkis: " + skaiciai.Average());

            var vidurkis = skaiciai.Average();
            Console.WriteLine("vidurkis: " + vidurkis);

            var zemesniuUzVidurki = 0;

            foreach (var skaicius in skaiciai)
            {
                if (skaicius < vidurkis)
                {
                    zemesniuUzVidurki++;
                }

            var suma = 0;

                if (skaicius % 2 == 0)
                {
                    zemesniuUzVidurki++;
                }
                Console.WriteLine("mazesni uz vidurki: ");
                Console.WriteLine("lyginiai: ");







            }
        }
    }
}
