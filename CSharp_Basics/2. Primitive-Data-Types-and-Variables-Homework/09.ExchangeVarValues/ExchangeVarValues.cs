using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 9.	Exchange Variable Values
//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values. 
//Print the variable values before and after the exchange.


namespace _09.ExchangeVarValues
{
    class ExchangeVarValues
    {
        static void Main(string[] args)
        {
            Console.Title = "Problem 9. Exchange Variable Values";
            // Solution 1: With two variables
            int a = 5;
            int b = 10;
            Console.WriteLine("Variables before exhange: \nint a = {0};\nint b = {1};", a, b);

            a = a + b;
            b = a - b;
            a = a - b;

            //// Solution 2: With three variables
            //int temp;
            //temp = a; 
            //a = b;    
            //b = temp;

            Console.WriteLine("\nVariables after exchange: \nint a = {0};\nint b = {1};\n", a, b);
        }
    }
}
