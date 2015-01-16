using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.BinaryToDecimalNumber
{
    class BinaryToDecimalNumber
    {
        static void Main()
        {
            Console.Write("Binary:  ");
            string binary = Console.ReadLine().ToString().TrimStart('0');

            long decNumber = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                //this skips zeroes in the formula below.
                if (binary[binary.Length - i - 1] == '0')
                {
                    continue;
                }

                decNumber += (long)Math.Pow(2, i);
            }

            Console.WriteLine("Decimal: {0}", decNumber);

        }
    }
}
