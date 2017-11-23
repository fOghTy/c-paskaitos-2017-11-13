using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Studentas
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentas = new Studentas("Haris", "Poteris", "Ryzis", 69, new List<int> {4 , 5 , 5 , 6 , 7}, new List<int> {8, 9, 6, 5, 10}, new List<int> {6, 7, 8, 10, 10});
            studentas.Isvedimas();
        }

    }
}
