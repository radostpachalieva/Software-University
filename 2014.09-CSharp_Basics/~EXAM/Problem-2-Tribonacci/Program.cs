﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_Tribonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            // Read input
		BigInteger trib1 = new BigInteger(int.Parse(Console.ReadLine()));
		BigInteger trib2 = new BigInteger(int.Parse(Console.ReadLine()));
		BigInteger trib3 = new BigInteger(int.Parse(Console.ReadLine()));
		int n = int.Parse(Console.ReadLine());

		// Solve the task
		if (n == 1)
			Console.WriteLine(trib1);
		else if (n == 2)
			Console.WriteLine(trib2);
		else if (n == 3)
			Console.WriteLine(trib3);
		else
		{
			for (int i = 4; i <= n; i++)
			{
				BigInteger tribNew = trib1 + trib2 + trib3;
				trib1 = trib2;
				trib2 = trib3;
				trib3 = tribNew;
			}
			Console.WriteLine(trib3);

        }
    }
}
