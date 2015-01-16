using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 1.	Sum of 3 Numbers
//Write a program that reads 3 real numbers from the console and prints their sum. Examples:
//  a	    b	    c	    sum
//  3	    4	    11	    18
//  -2	    0	    3	    1
//  5.5	    4.5	    20.1	30.1


namespace _01.Sum3Numbers
{
    class Sum3Numbers
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter the thurd number: ");
            double thurdNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("The sum of your numbers is = " + (firstNumber+secondNumber+thurdNumber));

        }
    }
}
