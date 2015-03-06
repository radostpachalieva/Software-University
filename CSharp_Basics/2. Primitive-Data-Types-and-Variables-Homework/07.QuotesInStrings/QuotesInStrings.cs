using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 7.	Quotes in Strings
//Declare two string variables and assign them with following value:
//The "use" of quotations causes difficulties.
//Do the above in two different ways: with and without using quoted strings. 
//Print the variables to ensure that their value was correctly defined.


namespace _07.QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main(string[] args)
        {
            Console.Title = "Problem 7. Quotes in Strings";

            string withoutQuotations = @"The ""use"" of quotations causes difficulties";
            string withQuotations = "The \"use\" of quotations causes difficulties";
            Console.WriteLine("Demo 1 - {0}\nDemo 2 - {1}", withoutQuotations, withQuotations);
        }
    }
}
