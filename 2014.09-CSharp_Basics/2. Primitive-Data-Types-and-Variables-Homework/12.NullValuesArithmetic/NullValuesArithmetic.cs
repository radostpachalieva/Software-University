using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 12.	Null Values Arithmetic
//Create a program that assigns null values to an integer and to a double variable. Try to print 
//these variables at the console. Try to add some number or the null literal to these variables and print the result.


namespace _12.NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            Console.Title = "Problem 12. Null Values Arithmetic";

            int? integerNull = null;
            double? doubleNull = null;
            Console.WriteLine("integerNull = {0}", integerNull + 100);
            Console.WriteLine("doubleNull = {0}", doubleNull + null);
        }
    }
}
