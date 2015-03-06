using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_MathExpression
{
    class MathExpression
    {
        static void Main(string[] args)
        {
            decimal numN = decimal.Parse(Console.ReadLine());
            decimal numM = decimal.Parse(Console.ReadLine());
            decimal numP = decimal.Parse(Console.ReadLine());

            decimal sumFirstPart = (numN * numN) + (1 / (numM * numP) + 1337);
            decimal sumSecondPart = numN - (128.523123123m * numP);
            int sumThirdPart = ((int)numM) % 180;
            decimal sumThirdPartSin = (decimal)Math.Sin(sumThirdPart);

            decimal sumAll = (sumFirstPart / sumSecondPart) + sumThirdPartSin;

            Console.WriteLine("{0:0.000000}", sumAll);
        }
    }
}
