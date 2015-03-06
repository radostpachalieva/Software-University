using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 3.	Min, Max, Sum and Average of N Nums
//Write a program that reads from the console a sequence of n integer Nums and returns the minimal, the maximal Num, 
//the sum and the average of all Nums (displayed with 2 digits after the decimal point). 
//The input starts by the Num n (alone in a line) followed by n lines, each holding an integer Num. 
//The output is like in the examples below. 

namespace _03.MinMaxSumAverageOfNNum
{
    class MinMaxSumAverageOfNNum
    {
        static void Main(string[] args)
        {
            Console.Write("How many Nums will compare? ");
            int n = int.Parse(Console.ReadLine());
            
            int minNum = int.MaxValue;
            int maxNum = int.MinValue;
            
            double sumNum = 0;
            double avgNum = 0;
            
            for (int i = 0; i < n; i++)
            {
                Console.Write(i);
                int Num = int.Parse(Console.ReadLine());

                minNum = Math.Min(minNum, Num);

                maxNum = Math.Max(maxNum, Num);

                sumNum += Num;

                avgNum = sumNum / n;
            }

            Console.WriteLine("Min = {0}", minNum);
            Console.WriteLine("Max = {0}", maxNum);
            Console.WriteLine("Sum = {0}", sumNum);
            Console.WriteLine("Avg = {0:F2}", avgNum);
        }
    }
}
