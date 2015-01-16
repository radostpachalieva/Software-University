using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.PrimeChecker
{
    class PrimeChecker
    {

        static void Main()
        {
            BigInteger inputNumber = BigInteger.Parse(Console.ReadLine());

            //Check with a method IsPrime();
            bool prime = IsPrime(inputNumber);

            //Print the boolean result
            Console.WriteLine(prime);
        }

        public static bool IsPrime(BigInteger candidate)
        {
            // Test whether the parameter is a prime number.
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            for (BigInteger i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }

    }
}
