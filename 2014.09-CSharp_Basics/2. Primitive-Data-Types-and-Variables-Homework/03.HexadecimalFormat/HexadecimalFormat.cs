using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 3.	Variable in Hexadecimal Format
//Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##). 
//Use Windows Calculator to find its hexadecimal representation. Print the variable and 
//ensure that the result is “254”.


namespace _03.HexadecimalFormat
{
    class HexadecimalFormat
    {
        static void Main(string[] args)
        {
            Console.Title = "Problem 3. Variable in Hexadecimal Format";
            int number = 0xFE;
            Console.WriteLine("The value {0} in hexadecimal format is {0:X}", number);
        }
    }
}
