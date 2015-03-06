using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_Wine_Glass
{
    class Wine_Glass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int starsInside = n-2;

            Console.WriteLine("{0}{1}{2}", '\\', new string('*', starsInside), '/');

            for (int i = 1; i <= n/2-1; i++)
            {
                Console.Write(new string('.', i));
                Console.Write(new string('\\', 1));
                Console.Write(new string('*', n-2-i*2));
                Console.Write(new string('/', 1));
                Console.Write(new string('.', i));
                Console.WriteLine();
            }

            int rows = 0;
            if (n >= 12)
            {
                rows = (n / 2) - 2;
            }

            else if (n < 12)
            {
                rows = (n / 2) - 1;
            }
             

            for (int i = 1; i <= rows; i++)
            {
                Console.Write(new string('.', (n/2)-1));
                
                Console.Write(new string('|', 2));
                
                Console.Write(new string('.', (n/2)-1));
                Console.WriteLine();
            }

            int count = n - 1 - (n / 2 - 1) - rows;

            for (int i = 1; i <= count; i++)
            {
                Console.Write(new string('-', n));
                Console.WriteLine();
            }

        }
    }
}
