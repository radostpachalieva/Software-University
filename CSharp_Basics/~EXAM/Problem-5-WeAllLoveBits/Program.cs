﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5_WeAllLoveBits
{
    class Program
    {
        static void Main(string[] args)
        {


                // Read N
		    int N = int.Parse(Console.ReadLine());

		    // For all N numbers
            for (int i = 1; i <= N; i++)
            {
                // Read P
                int P = int.Parse(Console.ReadLine());

                // Solve
                int Pnew = 0;
                while (P > 0)
                {
                    Pnew <<= 1;
                    if ((P & 1) == 1)
                    {
                        Pnew |= 1;
                    }
                    P >>= 1;
                }

                // Write Pnew
                Console.WriteLine(Pnew);
            }
        }
    }
}
