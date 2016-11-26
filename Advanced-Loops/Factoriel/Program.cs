using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var fact = 1;

            for (int i = n; i > 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
