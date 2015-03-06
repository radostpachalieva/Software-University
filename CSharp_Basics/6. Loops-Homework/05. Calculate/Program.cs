using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Problem 5.	Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. 
//Use only one loop. Print the result with 5 digits after the decimal point.
//n	x	S
//3	2	2.75000
//4	3	2.07407
//5	-4	0.75781


namespace _05.Calculate
{
    class Program
    {
        static void Main(string[] args)
        {            
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("X = ");
            int X = int.Parse(Console.ReadLine());

            double factoriel = 1;
            double totalResult = 1;

            for (int i = 1; i <= N; i++)
            {
                factoriel *= i;
                double result = Math.Pow(X, i);
                totalResult += factoriel / result;
            }

            Console.WriteLine("-----");
            Console.WriteLine("S = {0:F5}", totalResult);
        }
        
        //static ulong FactorialCalc(uint number)
        //{
        //    ulong sum = 1;
        //    for (uint i = 1; i <= number; i++)
        //    {
        //        sum = sum * i;
        //    }
        //    return sum;
        //}

        //static void Main()
        //{
        //    Console.Write("Please, enter X:");
        //    double x = int.Parse(Console.ReadLine());
        //    Console.Write("Please, enter N:");
        //    double n = int.Parse(Console.ReadLine());
        //    double theSum = 1;
        //    for (uint i = 1; i <= n; i++)
        //    {
        //        theSum = theSum + (FactorialCalc(i) / Math.Pow(x, i));
        //    }
        //    Console.WriteLine("S=1+1!/X+2!/X2+...+N!/XN = {0}", theSum);
        //}

    }
}
