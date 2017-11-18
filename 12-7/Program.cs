
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int pasirinkimas;

            do
            {
                Console.WriteLine("1 - suo, 2 - kate");
                pasirinkimas = Convert.ToInt32(Console.ReadLine());

                if (pasirinkimas < 1 || pasirinkimas > 2)
                {
                    Console.WriteLine("Blogai pasirinkote");
                }
            } while (pasirinkimas > 1 || pasirinkimas > 2);

            Console.WriteLine("pasirinkimas" + pasirinkimas);
        }
    }
}
