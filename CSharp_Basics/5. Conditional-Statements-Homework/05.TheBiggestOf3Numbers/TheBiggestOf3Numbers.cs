using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 5.	The Biggest of 3 Numbers
//Write a program that finds the biggest of three numbers. Examples:
//a	b	c	biggest
//5	2	2	5
//-2	-2	1	1
//-2	4	3	4
//0	-2.5	5	5
//-0.1	-0.5	-1.1	-0.1


namespace _05.TheBiggestOf3Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, insert 3 numbers: ");
            double num1 = double.Parse(Console.In.ReadLine());
            double num2 = double.Parse(Console.In.ReadLine());
            double num3 = double.Parse(Console.In.ReadLine());

            double max1 = Math.Max(num1, num2);
            double max2 = Math.Max(max1, num3);

            Console.WriteLine("\nThe biggest number is: \n{0}", max2);
        }
    }
}
