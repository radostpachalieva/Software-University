﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4_OddNumber
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long oddNumber = 0;

            for (int i = 0; i < n; i++)
            {
                long currentNumber = long.Parse(Console.ReadLine());
                oddNumber ^= currentNumber;     // oddNumber = oddNumber ^ currentNumber;
            }
            Console.WriteLine(oddNumber);
        }
    }
}
