using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_temp
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturos = { 14.5, 18.5, 20.4, -30 };

            var zemiausia = temperaturos[0];

            foreach (var temperatura in temperaturos)
            {
                if (temperatura < zemiausia)
                {
                    zemiausia = temperatura;
                }
            }

            Console.WriteLine("zemiausia temperatura: " + zemiausia);

            var didziausia = temperaturos[2];

            foreach (var temperatura in temperaturos )
            {
                if (temperatura > didziausia)
                {
                    didziausia = temperatura;
                }
            }
            Console.WriteLine("didziausia temperatura: " + didziausia);

            var suma = 0.0;
            var vidurkis = suma / temperaturos.Length;

            foreach (var temperatura in temperaturos)
            {
                suma += temperatura;
            }
            Console.WriteLine("vidurkis: " + vidurkis);

            var zemesniu_uz_vidurki_kiekis = 0;

            foreach (var temperatura in temperaturos)
            {
                if (temperatura < vidurkis)
                {
                    zemesniu_uz_vidurki_kiekis++;
                }
            }
                    Console.WriteLine("zemesniu uz vidurki kiekis: " + zemesniu_uz_vidurki_kiekis);
            var aukstesniu_uz_vidurki_kiekis = 0;

            foreach (var temperatura in temperaturos)
            {
                if (temperatura > vidurkis)
                {
                    aukstesniu_uz_vidurki_kiekis++;
                }
                    Console.WriteLine("aukstesniu uz vidurki kiekis: " + aukstesniu_uz_vidurki_kiekis);
            }
        }
    }
}
