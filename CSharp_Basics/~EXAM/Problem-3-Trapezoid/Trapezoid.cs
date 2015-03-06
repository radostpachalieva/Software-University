using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_Trapezoid
{
    class Trapezoid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int dotIndex = 1; dotIndex <= n; dotIndex++)
            {
                Console.Write(".");
            }

            for (int starIndex = 1; starIndex <= n; starIndex++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            //-----------------------------------------
            for (int row = 2; row <= n; row++)
            {
                for (int col = 1; col <= 2*n-1; col++)
                {
                    int starPosition = n - row + 2;


                    if(col == starPosition)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                } 

                Console.WriteLine("*");
            }
            Console.WriteLine();

            //-----------------------------------------
            for (int starIndex = 1; starIndex <= 2 * n; starIndex++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

        }
    }
}
