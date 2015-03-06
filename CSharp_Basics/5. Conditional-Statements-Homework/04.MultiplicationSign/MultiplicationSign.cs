using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 4.	Multiplication Sign
//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. 
//Use a sequence of if operators. 
//Examples:
//  a	    b	    c	    result
//  5	    2	    2	    +
//  -2	    -2	    1	    +
//  -2	    4	    3	    -
//  0	    -2.5	4	    0
//  -1	    -0.5	-5.1	-


namespace _04.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three real numbers:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            //Check for a border case first
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("\nThe product is (0)");
            }

            //There is no need to calculate the numbers. We need only to check
            //if the numbers are positive or negative, because of math "laws". 
            else if ((a < 0 && b > 0 && c > 0) || (b < 0 && a > 0 && c > 0)
                  || (c < 0 && b > 0 && a > 0) || (a < 0 && b < 0 && c < 0))
            {
                Console.WriteLine("\nThe product of the 3 numbers is negative (-)");
            }
            else
            {
                Console.WriteLine("\nThe product of the 3 numbers is positive (+)");
            }

            //---------------------------------------------------------------------


            //Console.Write("Please, enter a:");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Please, enter b:");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("Please, enter c:");
            //double c = double.Parse(Console.ReadLine());

            //double result = a * b * c;

            //if (result > 0)
            //{
            //    Console.WriteLine("Result: +");
            //}
            //else if (result < 0)
            //{
            //    Console.WriteLine("Result: -");
            //}
            //else
            //{
            //    Console.WriteLine("Result: 0");
            //}


        }
    }
}
