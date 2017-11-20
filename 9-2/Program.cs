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
            var gyvunas = Console.ReadLine();

            switch (gyvunas)
            {
                case ("papuga"):
                    Console.WriteLine("papuga");
                    break;
                case ("kate"):
                    Console.WriteLine("kate");
                    break;
                case ("ziurkenas"):
                    Console.WriteLine("ziurkenas");
                    break;
                case ("triusis"):
                    Console.WriteLine("triusis");
                    break;
                case ("kate"):
                    Console.WriteLine("kate");
                    break;
            }
            
        }
    }
}
