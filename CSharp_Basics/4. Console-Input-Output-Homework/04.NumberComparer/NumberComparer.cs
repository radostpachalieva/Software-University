using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 4.	Number Comparer
//Write a program that gets two numbers from the console and prints the greater of them. 
//Try to implement this without if statements. 
//Examples:
//  a	    b	    greater
//  5	    6	    6
//  10	    5	    10
//  0	    0	    0
//  -5	    -2	    -2
//  1.5	    1.6	    1.6

namespace _04.NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double b = double.Parse(Console.ReadLine());
            
            Console.WriteLine("The greater number is {0}", (a>b)?a:b);
        }
    }
}
