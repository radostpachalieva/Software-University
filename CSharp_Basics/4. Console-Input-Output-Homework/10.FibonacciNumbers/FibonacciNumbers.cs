using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Problem 10.	Fibonacci Numbers
//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
//(at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 
//Note that you may need to learn how to use loops. 
//Examples:
//  n	comments
//  1	0
//  3	0 1 1
//  10	0 1 1 2 3 5 8 13 21 34

namespace _10.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int previous = -1;
            int next = 1;
            for (int i = 0; i < n; i++)
            {
                int sum = next + previous;
                previous = next;
                next = sum;
                Console.Write(next + " ");
            }
            Console.WriteLine();
        }
    }
}
