using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite gyvuno rusi");
            var gyvunas = "suo";
            var papuga = "papuga";
            var kate = "kate";
            var ziurkenas = "ziurkenas";
            var triusis = "triusis";

            switch (gyvunas)
            {
                case 1:
                    Console.WriteLine(papuga);
                    break;
                case 2:
                    Console.WriteLine(kate);
                    break;
                case 3:
                    Console.WriteLine(ziurkenas);
                    break;
                case 4:
                    Console.WriteLine(triusis);
                    break;
                case 5:
                    Console.WriteLine(kate);
                    break;
        }
            
        }
    }
}
