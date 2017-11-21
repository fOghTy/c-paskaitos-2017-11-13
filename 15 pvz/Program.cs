using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.Pasisveikinti();
            programa.Pasisveikinti("Ieva");
            programa.Pasisveikinti("Ieva", "Jaksaityte");
            programa.Atsisveikinti();
            programa.Atsisveikinti("Ieva");
            programa.Atsisveikinti("Ieva", "Jaksaityte");
            StatinisMetodas();

            var sumosats = programa.Suma(4, 5);
            Console.WriteLine(sumosats);

            Console.WriteLine(programa.Suma(7, 5));

            var skirtumoats = programa.Skirtumas(4, 5);
            Console.WriteLine(skirtumoats);

            Console.WriteLine(programa.Skirtumas(7, 5));

            var dalmensats = programa.Dalmuo(4, 5);
            Console.WriteLine(dalmensats);

            Console.WriteLine(programa.Dalmuo(7, 5));

            Console.WriteLine("iveskite du skaicius");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());

            var suma = programa.Suma(pirmas, antras);
            var skirtumas = programa.Skirtumas(pirmas, antras);
            var sandauga = programa.Sandauga(pirmas, antras);
            var dalmuo = programa.Dalmuo(pirmas, antras);

            Console.WriteLine("{0} + {1} = {2}", pirmas, antras, suma);
            Console.WriteLine("{0} - {1} = {2}", pirmas, antras, skirtumas);
            Console.WriteLine("{0} * {1} = {2}", pirmas, antras, sandauga);
            Console.WriteLine("{0} / {1} = {2}", pirmas, antras, dalmuo);

            // rasysim cia
            // paskiekiamumas, tipas, pavadinimas (parametrai)
        }

        public void Pasisveikinti()

        {
            Console.WriteLine("Labas");
        }

        public void Pasisveikinti(string vardas)

        {
            Console.WriteLine("Labas, " + vardas);
        }

        public void Pasisveikinti(string vardas, string pavarde)

        {
            Console.WriteLine("Labas, " + vardas + " " + pavarde);
        }

        public void Atsisveikinti()

        {
            Console.WriteLine("Viso gero");
        }

        public void Atsisveikinti(string vardas)

        {
            Console.WriteLine("Viso gero" + vardas);
        }

        public void Atsisveikinti(string vardas, string pavarde)

        {
            Console.WriteLine("Viso gero" + vardas, " " + pavarde);
        }

        public static void StatinisMetodas()

        {
            Console.WriteLine("statinis metodas");
        }

        public int Suma(int a, int b)
        {
            return a + b;
        }

        public int Skirtumas(int a, int b)
        {
            return a - b;
        }

        public double Dalmuo(int a, int b)
        {
            return (double)a / b;
        }

        public int Sandauga(int a, int b)
        {
            return a * b;
        }
    }
}
