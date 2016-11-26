using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_N_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            for (int outNum = num; outNum >= 1; outNum--)
            {
                Console.WriteLine(outNum);
            }
        }
    }
}
