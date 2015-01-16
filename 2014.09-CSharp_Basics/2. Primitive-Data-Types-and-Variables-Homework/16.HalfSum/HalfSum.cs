using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 16.	* Half Sum
// иска се число.. и после толкова числа колкото 2 x първото число 

namespace _16.HalfSum
{
    class HalfSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numFirstNumber = 0;
            int numSecondNumber = 0;
            for (int i = 0; i < 2 * n; i++) // въвежда брояч i, който брои до 2n
            {
                int num = int.Parse(Console.ReadLine());
                if (i < n)
                {
                    numFirstNumber += num;  // 0+произволно число
                }
                else
                {
                    numSecondNumber += num;
                }
            }
            if (numFirstNumber == numSecondNumber)
            {
                Console.WriteLine("Yes, sum={0}", numFirstNumber);
            }
            else
            {
                Console.WriteLine("No, diff={0}", Math.Abs(numFirstNumber - numSecondNumber));
            }
        }
    }
}
