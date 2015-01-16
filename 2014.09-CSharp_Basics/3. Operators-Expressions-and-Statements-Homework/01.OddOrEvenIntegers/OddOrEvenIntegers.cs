using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 1.	Odd or Even Integers
//Write an expression that checks if given integer is odd or even. 
//Examples:
//n	Odd?
//3	true
//2	false
//-2	false
//-1	true
//0	false


namespace _01.OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {       
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("{0} is even => False", number);      //is even
            }
            else
            {
                Console.WriteLine("{0} is odd => True", number);      //is odd
            }

        }
    }
}
