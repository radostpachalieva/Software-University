using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 11.	* Numbers in Interval Dividable by Given Number
//Write a program that reads two positive integer numbers and prints how many numbers p exist between them 
//such that the reminder of the division by 5 is 0. 
//Examples:

//  start	end	p	comments
//  17	    25	2	20, 25
//  5	    30	6	5, 10, 15, 20, 25, 30
//  3	    33	6	5, 10, 15, 20, 25, 30
//  3	    4	0	-
//  99	    120	5	100, 105, 110, 115, 120
//  107	    196	18	110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195

namespace _11.NumbersIntervalDividableByGivenN
{
    class NumbersIntervalDividableByGivenN
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);


            //---------------------------------------------------------------

            //Console.Write("Please enter the Start number:");
            //int startNumber = int.Parse(Console.ReadLine());
            //Console.Write("Please enter the End number:");
            //int endNumber = int.Parse(Console.ReadLine());
            //int counter = 0;
            //for (int i = startNumber; i <= endNumber; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        counter++;
            //        Console.Write(i + " ");
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("There are {0} numbers that can be divided by 5.", counter);

        }
    }
}
