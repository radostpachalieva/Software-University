using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_Tic_Tac_Power
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int firstValue = int.Parse(Console.ReadLine());

            long result = 0;

            int position = x + 1;  // 1, 2, 3

            if (y == 1)
            {
                position = x + 4;  // 4, 5, 6
            }
            else if (y == 2)
            {
                position = x + 7;  // 7, 8, 9
            }

            firstValue += position - 1;
            result = (long)Math.Pow(firstValue, position);
            Console.WriteLine(result);

        }
    }
}
