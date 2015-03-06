using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Problem 7.	Sum of 5 Numbers
//Write a program that enters 5 numbers (given in a single line, separated by a space), 
//calculates and prints their sum. 
//Examples:
//numbers	    sum		numbers	            sum		numbers	                sum
//1 2 3 4 5	    15		10 10 10 10 10	    50		1.5 3.14 8.2 -1 0	    11.84


namespace _07.SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            //-----------------------------------------------------
            //Console.WriteLine("Enter Numbers");
            //string[] numbers = Console.ReadLine().Split();
            //double a = double.Parse(numbers[0]);
            //double b = double.Parse(numbers[1]);
            //double c = double.Parse(numbers[2]);
            //double d = double.Parse(numbers[3]);
            //double e = double.Parse(numbers[4]);
            //double sum = a + b + c + d + e;
            //Console.WriteLine("Sum: {0}", sum);
            //-----------------------------------------------------

            string[] input = Console.ReadLine().Split();
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                double n = double.Parse(input[i]);
                sum += n;
            }
            Console.WriteLine(sum);

            //--------------------------------------------------

            //Console.Write("Please, write 5 numbers separated by a space: ");
            //var numbers = Console.ReadLine().Split().Take(5);
            //Double[] digits = numbers.Select(d => Convert.ToDouble(d)).ToArray();
            //double sum = digits.Sum();
            //Console.WriteLine("The sum is: " + sum);

        }
    }
}
