using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 7.	Sort 3 Numbers with Nested Ifs
//Write a program that enters 3 real numbers and prints them sorted in descending order. 
//Use nested if statements. Don’t use arrays and the built-in sorting functionality. 
//Examples:
//a	b	c	result
//5	1	2	5 2 1
//-2	-2	1	1 -2 -2
//-2	4	3	4 3 -2
//0	-2.5	5	5 0 -2.5
//-1.1	-0.5	-0.1	-0.1 -0.5 -1.1
//10	20	30	30 20 10
//1	1	1	1 1 1


namespace _07.Sort3NumbersWithNestedIfs
{
    class Sort3NumbersWithNestedIfs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, insert 3 numbers: ");
            double num1 = double.Parse(Console.In.ReadLine());
            double num2 = double.Parse(Console.In.ReadLine());
            double num3 = double.Parse(Console.In.ReadLine());

            Console.WriteLine("\nSorted in descending order: ");

            if (num1 >= num2 && num1 >= num3)
            {
                if (num2 >= num3)
                    Console.WriteLine("{0}\n{1}\n{2}\n", num1, num2, num3);
                else Console.WriteLine("{0}\n{1}\n{2}\n", num1, num3, num2);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                if (num1 >= num2)
                    Console.WriteLine("{0}\n{1}\n{2}\n", num2, num1, num3);
                else Console.WriteLine("{0}\n{1}\n{2}\n", num2, num3, num1);
            }
            else if (num3 >= num1 && num3 >= num2)
            {
                if (num1 >= num2)
                    Console.WriteLine("{0}\n{1}\n{2}\n", num3, num1, num2);
                else Console.WriteLine("{0}\n{1}\n{2}\n", num3, num2, num1);
            }
        }
    }
}
