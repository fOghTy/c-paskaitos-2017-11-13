using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pazymiai = { 7, 8, 9, 10 };

            string[] markes = new string [5];
            markes[0] = "audi";
            markes[1] = "mbenz";
            markes[2] = "bmw";
            markes[3] = "opel";
            markes[4] = "subaru";

            int[] skaiciai = { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("masyvu dydziai");
            Console.WriteLine("pazymiai: " + pazymiai.Length);
            Console.WriteLine("markes: " + markes.Length);
            Console.WriteLine("skaiciai: " + skaiciai.Length);

            Console.WriteLine("markes masyvo");
            Console.WriteLine("pirma reiksme: " + markes.First());
            Console.WriteLine("paskutine reiksme: " + markes.Last());

            Console.WriteLine("skaiciu masyvo");
            Console.WriteLine("pirma reiksme: " + skaiciai.First());
            Console.WriteLine("paskutine reiksme: " + skaiciai.Last());

            var skc = new int[5];
            Console.WriteLine("iveskite 5 skaicius");

            for (int a = 0; a < 5; a++)
            {
                Console.Write(a + 1 + ": " );
                skc[a] = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
