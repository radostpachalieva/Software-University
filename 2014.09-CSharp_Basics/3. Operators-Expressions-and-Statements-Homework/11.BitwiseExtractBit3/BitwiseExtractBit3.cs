using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 11.	Bitwise: Extract Bit #3
//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. 
//The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0. 
//Examples:
//n	    binary representation       bit #3
//5	    00000000    00000101	    0
//0	    00000000    00000000	    0
//15	00000000    00001111	    1
//5343	00010100    11011111	    1
//62241	11110011    00100001	    0


namespace _11.BitwiseExtractBit3
{
    class BitwiseExtractBit3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");               // Input number
            int number = int.Parse(Console.ReadLine());         // Read number

            int mask = 1 << 3;                                  // Making mask. 1 is 0001 << 3 = 0100
            int collation = number & mask;                      // The number & 0100

            if (collation == 0)                                 // Boolean checking in if()
                {
                    Console.WriteLine("Third bit is '0' " + Convert.ToString(number, 2).PadLeft(16, '0')); // Output if
                }
            else
                {
                    Console.WriteLine("Third bit is '1' " + Convert.ToString(number, 2).PadLeft(16, '0'));  // Output else
                }
        }
    }
}
