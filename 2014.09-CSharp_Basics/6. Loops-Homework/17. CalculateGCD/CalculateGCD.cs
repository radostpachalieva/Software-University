using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.CalculateGCD
{
    class CalculateGCD
    {
        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int c = 0;
            while (b != 0)
            {
                c = b;
                b = a % b;
                a = c;
            }
            Console.Write("GCD(a,b)={0}", a);
            Console.WriteLine();
        }
    }
}
