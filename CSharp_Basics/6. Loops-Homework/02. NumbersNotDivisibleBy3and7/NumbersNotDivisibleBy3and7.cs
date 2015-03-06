using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 2.	Numbers Not Divisible by 3 and 7
//Write a program that enters from the console a positive integer n and prints all the numbers 
//from 1 to n not divisible by 3 and 7, on a single line, separated by a space. 
//Examples:
//n	output
//3	1 2
//10	1 2 4 5 8 10

namespace _02.NumbersNotDivisibleBy3and7
{
    class NumbersNotDivisibleBy3and7
    {
        static void Main(string[] args)
        {

            Console.Write("n = ");
            string numberAsString = Console.ReadLine();
            int n = int.Parse(numberAsString);
            
            for (int i = 1; i <= n; i++)
            {
                if ((i % 7) == 0 || (i % 3) == 0)
                    continue; // break;

                Console.WriteLine(i + " ");
            }

        }
    }
}
