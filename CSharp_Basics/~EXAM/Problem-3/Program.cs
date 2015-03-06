using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("{0}{1}{0}", new string('.', 3*n/2), new string('*', 1));

            for (int i = 1; i <= 2*((n/2)+2) ; i += 2)
            {
                int dotCountOut = (3*n/2 - (i+2)/2);
              
                Console.Write(new string('.', dotCountOut));
                Console.Write('*');
                Console.Write(new string('.', i));
                Console.Write('*');
                Console.Write(new string('.', dotCountOut));
                Console.WriteLine();
            }


            int outSide = n - 3;

            for (int i = 1; i <= n - 3; i += 2)
            {
                Console.Write(new string('.', (outSide - i)));
                Console.Write('*');
                Console.Write(new string('.', n + 2 * i + 4));
                Console.Write('*');
                Console.Write(new string('.', (outSide - i)));
                Console.WriteLine();
            }

                Console.Write('*');
                Console.Write(new string('.', (n-2)));
                Console.Write('*');
                Console.Write(new string('.', n));
                Console.Write('*');
                Console.Write(new string('.', (n-2)));
                Console.Write('*');
                Console.WriteLine();

                int outsideThird = 1;
                for (int i = 4; i <= n; i += 2)
                {
                    int outsideSecond = n - i;
                    

                    Console.Write('*');
                    Console.Write(new string('.', (outsideSecond)));
                    Console.Write('*');
                    Console.Write(new string('.', outsideThird));
                    Console.Write('*');
                    Console.Write(new string('.', n));
                    Console.Write('*');
                    Console.Write(new string('.', outsideThird));
                    Console.Write('*');
                    Console.Write(new string('.', (outsideSecond)));
                    Console.Write('*');
                    Console.WriteLine();

                    outsideThird+=2;
                }


                for (int i = 1; i <= n - 1; i++)
                {
                
                    Console.Write(new string('.', (n - i)));
                    Console.Write('*');
                    Console.Write(new string('.', n -2 + 2 * i));
                    Console.Write('*');
                    Console.Write(new string('.', (n - i)));
                    Console.WriteLine();
                }

                Console.WriteLine("{0}", new string('*', 3 * n));
        }
    }
}
