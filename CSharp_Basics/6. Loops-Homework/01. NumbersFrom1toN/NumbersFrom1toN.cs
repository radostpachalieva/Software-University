using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 1.	Numbers from 1 to N
//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, 
//on a single line, separated by a space. 
//Examples:
//n	output
//3	1 2 3
//5	1 2 3 4 5

namespace _01.NumbersFrom1toN
{
    class NumbersFrom1toN
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //// Second solution.. 
            //int i = 1;
            //while (i <= n)
            //{
            //    Console.Write(i + " ");
            //    i++;
            //}
            //Console.WriteLine();
                       
        }
    }
}
