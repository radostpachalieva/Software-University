using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_LeastMajorityMultiple
{
    class LeastMajorityMultiple
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            int max = 100 * 100 * 100;

            for (int number = 4; number < max; number++)
            {
                int divsCount = 0;
                if(number % a == 0)
                {
                    divsCount++;
                }

                if (number % b == 0)
                {
                    divsCount++;
                }

                if (number % c == 0)
                {
                    divsCount++;
                }

                if (number % d == 0)
                {
                    divsCount++;
                }

                if (number % e == 0)
                {
                    divsCount++;
                }

                if (divsCount >= 3)
                {
                    Console.WriteLine(number);
                    break;
                }

            }

        }
    }
}
