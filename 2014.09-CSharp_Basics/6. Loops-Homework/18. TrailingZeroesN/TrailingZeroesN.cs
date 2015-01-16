using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _18.TrailingZeroesN
{
    class TrailingZeroesN
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer number N: ");
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            Console.WriteLine();
            BigInteger trailingZeroes = 0;
            int sum = 5;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);

            while (n >= sum)
            {
                trailingZeroes += (n / sum);
                sum *= 5;
            }
            Console.WriteLine("The number of the trailing zeroes at the end of ({0}!) is: {1}\n", n, trailingZeroes);

        }
    }
}
