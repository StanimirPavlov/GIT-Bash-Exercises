using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_In_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write("Еnter a number in the range [1...100]: ");

            while (n < 1 || n > 100)
            {
                Console.WriteLine(n);
                Console.WriteLine("Invalid number!");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(n);
            Console.WriteLine("The number is: {0}", n);
        }
    }
}
