using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var counter = 1;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < row; col++)
                {
                        Console.Write(counter + " ");
                        counter++;
                    if (counter > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (counter > n)
                {
                    break;
                }
            }
        }
    }
}

