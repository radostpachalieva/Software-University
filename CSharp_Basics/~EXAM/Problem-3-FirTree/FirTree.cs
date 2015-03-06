using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_FirTree
{
    class FirTree
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n - 1; i++)
            {
                int outDashes = n - i - 1;
                int MidDashes = 2 * i - 1;
                if (i < n - 1)
                {
                    Console.WriteLine(new string('.', outDashes) + new string('*', MidDashes)
                    + new string('.', outDashes));
                }
                else
                {
                    outDashes = n - 2;
                    MidDashes = 1;

                    {
                        Console.WriteLine(new string('.', outDashes) + new string('*', MidDashes)
                        + new string('.', outDashes));
                    }
                }

            }

        }
    }
}
