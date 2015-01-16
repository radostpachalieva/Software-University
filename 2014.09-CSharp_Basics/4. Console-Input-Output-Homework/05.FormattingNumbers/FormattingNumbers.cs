using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 5.	Formatting Numbers
//Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c 
//and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. 
//The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, 
//padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; 
//the number c should be printed with 3 digits after the decimal point, left aligned. 
//Examples:
//  a	    b	    c	        result
//  254	    11.6	0.5	        |FE        |0011111110|     11.60|0.500     |
//  499	    -0.5559	10000	    |1F3       |0111110011|     -0.56|10000     |
//  0	    3	    -0.1234	    |0         |0000000000|         3|-0.123    |


namespace _05.FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {

            Console.Write("Enter an integer number(0 ≤ a ≤ 500): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter first floating-point number: ");
            decimal b = decimal.Parse(Console.ReadLine());

            Console.Write("Enter second floating-point number: ");
            decimal c = decimal.Parse(Console.ReadLine());

            Console.Write("{0,-10}{1,-10}{2,-10}", a, b, c);

            Console.Write(string.Format("|{0,-10:X}|", a));
            Console.Write("Hex: {0:X}", a);

            string binary = Convert.ToString(a, 2);            //Console.Write(Convert.ToString(a, 2).PadLeft(10, '0'));
            Console.Write(binary.PadLeft(10, '0'));

            Console.Write("|{0,10:F2}|", b);
            Console.WriteLine("{0,-10:F3}|", c);

        }
    }
}
