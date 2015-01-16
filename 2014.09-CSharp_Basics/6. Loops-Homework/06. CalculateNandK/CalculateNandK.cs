using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Problem 6.	Calculate N! / K!
//Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. 
//Examples:
//n	k	n! / k!
//5	2	60
//6	5	6
//8	3	6720

namespace _06.CalculateNandK
{
    class CalculateNandK
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

            double totalResult = factorielN / factorielK;
            Console.WriteLine("n! / k! = {0}", totalResult);
        }
    }
}
