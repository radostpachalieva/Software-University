using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Problem 7.	Calculate N! / (K! * (N-K)!)
//In combinatorics, the number of ways to choose k different members out of a group of n different elements 
//(also known as the number of combinations). 
//For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. 
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
//Try to use only two loops. 
//Examples:
//n	k	n! / (k! * (n-k)!)
//3	2	3
//4	2	6
//10 	6	210
//52	5	2598960

namespace _07.CalculateNformula
{
    class CalculateNformula
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int K = int.Parse(Console.ReadLine());

            double factorielN = 1;
            double factorielK = 1;

            for (int i = 1; i <= N; i++)
            {
                factorielN *= i;
            }

            for (int i = 1; i <= K; i++)
            {
                factorielK *= i;
            }

            double dev = N-K;
            double factorielDev = 1;
            for (int i = 1; i <= dev; i++)
            {
                factorielDev *= i;
            }

            double totalResult = factorielN / (factorielK * (factorielDev));
            
            Console.WriteLine("n! / k! = {0}", totalResult);

        }
        
        //static BigInteger FactorialCalc(uint number)
        //{
        //    BigInteger sum = 1;
        //    for (int i = 1; i <= number; i++)
        //    {
        //        sum = sum * i;
        //    }
        //    return sum;
        //}

        //static void Main()
        //{
        //    Console.WriteLine("Calculate   N!/(K!*(N-K)!");
        //    Console.Write("Enter N:");
        //    uint n = uint.Parse(Console.ReadLine());
        //    Console.Write("Enter K:");
        //    uint k = uint.Parse(Console.ReadLine());
        //    BigInteger result = FactorialCalc(n) / ((FactorialCalc(k) * FactorialCalc(n - k)));
        //    Console.Write("The Result is:{0}", result);
        //    Console.WriteLine();
        //}


    }
}
