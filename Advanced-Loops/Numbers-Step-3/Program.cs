using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            for (int outNum = 1; outNum <= num; outNum += 3)
            {
                Console.WriteLine(outNum);
            }
        }
    }
}
