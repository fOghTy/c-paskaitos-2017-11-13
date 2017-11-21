using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_paz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pazymiai = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var geras = 10;

            foreach (var pazimys in pazymiai)
            {
                if (pazimys < geras)
                {
                    pazimys = geras
                }
            }

        }
    }
}
