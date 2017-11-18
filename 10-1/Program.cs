using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var darboValandu = 8;

            Console.WriteLine("Kiek darbuotojas gali iskepti kepalu per valanda?");
            var kepaluPerValanda = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kiek darbuotoju turi kepykla?");
            var darbuotojai = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vieno kepalo savikaina?");
            var savikaina = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vieno kepalo pardavimo kaina?");
            var pardavimoKaina = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kiek kepykla turi per diena uzsakymu?");
            var uzsakymai= Convert.ToInt32(Console.ReadLine());

            // Suskaiciuoti kiek kepykla per viena darbo diena spes iskepti duonos kepalu.
            var perDienaDuonosKepalu = kepaluPerValanda * darbuotojai * darboValandu;

            Console.WriteLine("Kiek kepykla per viena darbo diena spes iskepti duonos kepalu: " + perDienaDuonosKepalu);

            // Apskaiciuoti visu kepalu savikaina, gautas pajamas pardavus ir is to gauto pelno dali.
            var visuSavikaina = perDienaDuonosKepalu * savikaina;
            var visuPajamos = perDienaDuonosKepalu * pardavimoKaina;
            var pelnas = visuPajamos - visuSavikaina;

            Console.WriteLine("visu savikaina: " + visuSavikaina);
            Console.WriteLine("pajamos: " + visuPajamos);
            Console.WriteLine("pelnas: " + pelnas);

            // Patikrinti ar kepykla spes iskepti visus tos dienos uzsakymus. Jei ne, suskaiciuoti kiek kepalu nespes iskepti.

            if (perDienaDuonosKepalu > uzsakymai)
            {
                Console.WriteLine("dienos norma ivykdita!");
            }
            else
            {
                Console.WriteLine("jums dar truksa: " + (uzsakymai - perDienaDuonosKepalu));
            }
        }
    }
}
