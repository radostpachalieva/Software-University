using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 12.	* Zero Subset
//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0. 
//Assume that repeating the same subset several times is not a problem. 
//Examples:
//numbers	result
//3  -2  1  1 8 -2 + 1 + 1 = 0
//3 1 -7 35 22	no zero subset
//1 3 -4 -2 -1	1 + -1 = 0
//1 + 3 + -4 = 0
//3 + -2 + -1 = 0
//1 1 1 -1 -1	1 + -1 = 0
//1 + 1 + -1 + -1 = 0
//1 + -1 + 1 + -1 = 0
//…
//0 0 0 0 0	0 + 0 + 0 + 0 + 0 = 0
//Hint: you may check for zero each of the 32 subsets with 32 if statements.

namespace _12.ZeroSubset
{
    class ZeroSubset
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string[] strNumbers = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            //The input is in one line, so we need to split it and convert to integer

            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(strNumbers[i]);
            }

            int a = numbers[0];
            int b = numbers[1];
            int c = numbers[2];
            int d = numbers[3];
            int e = numbers[4];

            Console.WriteLine();
            if ((a + b + c + d + e) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
                return;
            }

            if ((a + b) == 0) Console.WriteLine("{0} + {1} = 0", a, b);
            if ((a + c) == 0) Console.WriteLine("{0} + {1} = 0", a, c);
            if ((a + d) == 0) Console.WriteLine("{0} + {1} = 0", a, d);
            if ((a + e) == 0) Console.WriteLine("{0} + {1} = 0", a, e);
            if ((c + b) == 0) Console.WriteLine("{0} + {1} = 0", c, b);
            if ((c + d) == 0) Console.WriteLine("{0} + {1} = 0", c, d);
            if ((d + b) == 0) Console.WriteLine("{0} + {1} = 0", d, b);
            if ((e + b) == 0) Console.WriteLine("{0} + {1} = 0", e, b);
            if ((e + d) == 0) Console.WriteLine("{0} + {1} = 0", e, d);
            if ((e + c) == 0) Console.WriteLine("{0} + {1} = 0", c, e);

            if ((a + b + c) == 0) Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
            if ((a + b + d) == 0) Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
            if ((a + b + e) == 0) Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
            if ((a + c + d) == 0) Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
            if ((a + c + e) == 0) Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
            if ((a + d + e) == 0) Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
            if ((b + c + e) == 0) Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
            if ((b + d + c) == 0) Console.WriteLine("{0} + {1} + {2} = 0", b, d, c);
            if ((b + d + e) == 0) Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
            if ((c + d + e) == 0) Console.WriteLine("{0} + {1} , {2} = 0", c, d, e);

            if ((a + b + c + d) == 0) Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
            if ((a + b + c + e) == 0) Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
            if ((a + b + d + e) == 0) Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
            if ((a + e + c + d) == 0) Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, e, c, d);
            if ((e + b + c + d) == 0) Console.WriteLine("{0} + {1} + {2} + {3} = 0", e, b, c, d);

            else
            {
                Console.WriteLine("no zero subset");
            }
        }
    }
}
