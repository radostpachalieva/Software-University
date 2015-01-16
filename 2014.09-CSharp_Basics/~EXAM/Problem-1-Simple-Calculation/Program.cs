using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_Simple_Calculation
{
    class Program
    {
        static void Main(string[] args)
        {

            // Read input data
            decimal X = decimal.Parse(Console.ReadLine());
            decimal Y = decimal.Parse(Console.ReadLine());

            // Solve the problem
            if (X == 0 && Y == 0)
            {
                Console.WriteLine(0);
            }
            else if (X == 0)
            {
                Console.WriteLine(5);
            }
            else if (Y == 0)
            {
                Console.WriteLine(6);
            }
            else if (X > 0 && Y > 0)
            {
                Console.WriteLine(1);
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine(2);
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine(3);
            }
            else // if (X > 0 && Y < 0)
            {
                Console.WriteLine(4);
            }

        }
    }
}
