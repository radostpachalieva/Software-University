using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_House_with_a_Window
{
    class HouseWithWindow
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());


            //int dotCountOut = n - 1;
            //int dotCountIn = n;

            Console.WriteLine("{0}{1}{0}", new string('.', n-1), new string('*', 1));

            int outer = n - 2;
            int inner = 1;

            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write(new string('.', outer));
                Console.Write('*');
                Console.Write(new string('.', inner));
                Console.Write('*');
                Console.Write(new string('.',outer));
                Console.WriteLine();
                outer--;
                inner += 2;
            }

            Console.WriteLine("{0}", new string('*', 2*n -1));

            for (int i = 1; i <= n/4; i++)
            {
                Console.Write('*');
                Console.Write(new string('.', 2*n - 3));
                Console.Write('*');
                Console.WriteLine();
            }

            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write('*');
                Console.Write(new string('.', n /2 ));
                Console.Write(new string('*', n - 3));
                Console.Write(new string('.', n /2));
                Console.Write('*');
                Console.WriteLine();
            }

            for (int i = 1; i <= n / 4; i++)
            {
                Console.Write('*');
                Console.Write(new string('.', 2 * n - 3));
                Console.Write('*');
                Console.WriteLine();
            }

            Console.WriteLine("{0}", new string('*', 2 * n - 1));


        }
    }
}
