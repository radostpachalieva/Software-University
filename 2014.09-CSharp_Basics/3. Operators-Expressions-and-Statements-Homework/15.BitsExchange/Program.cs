using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 15.	* Bits Exchange
//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. 
//Examples:
//n	            binary representation of n	            binary result	                        result
//1140867093	01000100 00000000 01000000 00010101	    01000010 00000000 01000000 00100101	    1107312677
//255406592	    00001111 00111001 00110010 00000000	    00001000 00111001 00110010 00111000	    137966136
//4294901775	11111111 11111111 00000000 00001111	    11111001 11111111 00000000 00111111	    4194238527
//5351	        00000000 00000000 00010100 11100111	    00000100 00000000 00010100 11000111	    67114183
//2369124121	10001101 00110101 11110111 00011001	    10001011 00110101 11110111 00101001	    2335569705


namespace _15.BitsExchange
{
    class Program
    {
        static void Main(string[] args)
        {

            uint num = uint.Parse(Console.ReadLine()); 
            string binaryNumber = Convert.ToString(num, 2).PadLeft(32, '0');
            uint result = num;
            uint mask1 = 7 << 3;
            uint mask2 = 7 << 24;
            
            uint bits345 = num & mask1;
            uint bits2456 = num & mask2;
            
            bits345 <<= 21;
            bits2456 >>= 21;

            //Replace binary digits with zeroes in bits 3, 4, 5 and 24, 25, 26
            result = ~mask1 & result;
            result = ~mask2 & result;
            
            result = result | bits345;
            result = result | bits2456;
            string binaryResult = Convert.ToString(result, 2).PadLeft(32, '0');
            
            Console.WriteLine("\nBinary of n: {0}", binaryNumber);
            Console.WriteLine("Binary result: {0}", binaryResult);
            Console.WriteLine("Result: " + result);




            //---------Advanced------------------------------------------------------


        //    long num = long.Parse(Console.ReadLine());
        //    string binaryNumber = Convert.ToString(num, 2).PadLeft(32, '0');
        //    Console.Write("p = ");
        //    sbyte p = sbyte.Parse(Console.ReadLine());
        //    if (p >= 0)
        //    {
        //        Console.WriteLine("Binary representation of N: {0}", binaryNumber);
        //    }
        //    Console.Write("q = ");
        //    sbyte q = sbyte.Parse(Console.ReadLine());
        //    Console.Write("k = ");
        //    sbyte k = sbyte.Parse(Console.ReadLine());
        //    if (Math.Max(p, q) + k > 32 || Math.Min(p, q) < 0)
        //    {
        //        Console.WriteLine("out of range");
        //        return;
        //    }
        //    if (Math.Abs(q - p) < k)
        //    {
        //        Console.WriteLine("overlapping");
        //        return;
        //    }
        //    for (byte i = 0; i < k; i++)
        //    {
        //        num = BitExchange(num, p + i, q + i);
        //    }
        //    Console.WriteLine("Result: {0}", num);
        //    string binaryResult = Convert.ToString(num, 2).PadLeft(16, '0');
        //    Console.WriteLine("Binary result: {0}", binaryResult);
        //}
        //static long BitExchange(long num, int p, int q)
        //{
        //    long shiftNumP = num >> p;
        //    byte bitP = (byte)(shiftNumP & 1);
        //    long shiftNumQ = num >> q;
        //    byte bitQ = (byte)(shiftNumQ & 1);
        //    //change bit P
        //    if (bitP == 0)
        //    {
        //        long maskP = (long)~(1 << q);
        //        num = num & maskP;
        //    }
        //    else
        //    {
        //        long maskP = (long)(1 << q);
        //        num = num | maskP;
        //    }
        //    //change bit Q
        //    if (bitQ == 0)
        //    {
        //        long maskQ = (long)~(1 << p);
        //        num = num & maskQ;
        //    }
        //    else
        //    {
        //        long maskQ = (long)1 << p;
        //        num = num | maskQ;
        //    }
        //    return num;




        }
    }
}
