﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 50;
            var pirmas = a / 10; // 5
            var antras = a % 10; // 0
                 Console.WriteLine("pirmas: " + pirmas);
                 Console.WriteLine("antras: " + antras);
                 Console.WriteLine(pirmas * antras);
        }
    }
}
