using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 13.	* Comparing Floats
//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. 
//Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the 
//floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than 
//a fixed constant eps. Examples:
//Number a	    Number b	Equal   (with precision eps=0.000001)	Explanation
//5.3	        6.01	    false	The difference of 0.71 is too big (> eps)
//5.00000001	5.00000003	true	The difference 0.00000002 < eps
//5.00000005	5.00000001	true	The difference 0.00000004 < eps
//-0.0000007	0.00000007	true	The difference 0.00000077 < eps
//-4.999999	    -4.999998	false	Border case. The difference 0.000001 == eps. We consider the numbers are different.
//4.999999	    4.999998	false	Border case. The difference 0.000001 == eps. We consider the numbers are different.


namespace _13.ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            Console.Title = "Problem 13.* Comparing Floats";

            Console.Write("Add your first number= ");
            double firstNum = (double.Parse(Console.ReadLine()));
            Console.Write("Add your second number= ");
            double secondNum = (double.Parse(Console.ReadLine()));

            bool compare = (Math.Abs(firstNum - secondNum) < 0.000001); // Comparing the numbers. Math.Abs - An absolute value is not negative. It is the same as the original value but with no negative sign. The Math.Abs method in the .NET Framework provides a tested absolute value function. It deals with certain edge cases.
           
            Console.WriteLine("Are number {0} and {1} equal? {2}", firstNum, secondNum, compare);

        }
    }
}
