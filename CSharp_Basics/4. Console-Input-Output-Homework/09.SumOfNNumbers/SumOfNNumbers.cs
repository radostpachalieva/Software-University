using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 9.	Sum of n Numbers
//Write a program that enters a number n and after that enters more n numbers and calculates and 
//prints their sum. Note that you may need to use a for-loop.

namespace _09.SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers you want to sum?: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            Console.WriteLine("Enter these numbers.");

            for (int i = 0; i < n; i++)
            {
                double inputNumber = double.Parse(Console.ReadLine());        //    sum += double.Parse(Console.ReadLine());
                sum += inputNumber;
            }

            Console.WriteLine("Total sum: " + sum);

        }
    }
}
