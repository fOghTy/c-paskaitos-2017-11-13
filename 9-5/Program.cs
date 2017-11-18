using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("rezultatai");
            var valandos = 8;
            var kpv = Convert.ToInt32(Console.ReadLine());
            var darbuotojai = Convert.ToInt32(Console.ReadLine());
            var ksavikaina = Convert.ToInt32(Console.ReadLine());
            var kpardavimokaina = Convert.ToInt32(Console.ReadLine());
            var kturitadienauzsakymu = Convert.ToInt32(Console.ReadLine());

            if (valandos)
            {
                Console.WriteLine("darbo valandu");
            }
            else if (kpv)
            {
                Console.WriteLine("kiek iskepa per valanda");
            }
            else if (darbuotojai)
            {
                Console.WriteLine("kiek darbuotoju");
            }
            else if (ksavikaina)
            {
                Console.WriteLine("kepalu savikaina");
            }
            else if (kpardavimokaina)
            {
                Console.WriteLine("kepalu pardavimo kaina");
            }
            else if (kturitadienauzsakymu)
            {
                Console.WriteLine("kiek uzsakymu per diena");
            }


        }
    }
}
