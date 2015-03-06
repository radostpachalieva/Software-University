using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 2.	Float or Double?
//Which of the following values can be assigned to a variable of type float and 
//which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? 
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.


namespace _02.FloatOrDouble
{
    class FloatOrDouble
    {
        static void Main(string[] args)
        {
            Console.Title = "Problem 2. Float or Double?";

            double numberOne = 34.567839023d;
            float numberTwo = 12.345f;
            double numberThree = 8923.1234857d;
            float numberFour = 3456.091f;

            Console.WriteLine(("Assigned to a variable of type float are ") + (numberTwo) + (" and ") + (numberFour));
            Console.WriteLine(("Assigned to a variable of type float are ") + (numberOne) + (" and ") + (numberThree));

        }
    }
}
