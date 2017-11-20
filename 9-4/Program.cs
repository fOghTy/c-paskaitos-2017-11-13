using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite pasirinkimo numeri");
            Console.WriteLine(" 1 - vanduo");
            Console.WriteLine(" 2 - kava");
            Console.WriteLine(" 3 - arbata");
            var a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("jus pasirinkote vandeni");
                    break;
                case 2:
                    Console.WriteLine("just pasirinkote kava");
                    break;
                case 3:
                    Console.WriteLine("jus pasirinkote arbata");
                    break;
                default:
                    Console.WriteLine("tokio pasirinkimo nera");
                    break;
            }
        }
    }
}
