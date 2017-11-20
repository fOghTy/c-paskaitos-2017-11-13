using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - stacionarus kompiuteris");
            Console.WriteLine("2 - nesiojamas kompiuteris");
            Console.WriteLine("3 - plansete");
            Console.WriteLine("Pasirinkite");
            var a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("namu kompiutreis");
                    break;
                case 2:
                    Console.WriteLine("nesiojamas galima naudoti daug kur");
                    break;
                case 3:
                    Console.WriteLine("plansete galima naudoti visur");
                    break;
                default:
                    Console.WriteLine("tokio pasirinkimo nera");
                    break;
            }

        }
    }
}
