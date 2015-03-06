﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FibonacciNumbers
{
    class FibonacciNumbers
    {

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = Fib(n);

            Console.WriteLine(result);
        }

        private static BigInteger Fib(int n)
        {
            BigInteger firstNum = 0;
            BigInteger secondNum = 1;
            BigInteger nextNum;

            if (n == 1) return firstNum;
            if (n == 2) return secondNum;
            else
            {

                for (int i = 1; i <= n; i++)
                {
                    nextNum = firstNum + secondNum;
                    firstNum = secondNum;
                    secondNum = nextNum;

                    if (i == n)
                    {
                        return nextNum;
                    }
                }
            }

            return 0;
        }

    }
}
