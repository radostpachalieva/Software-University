using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 12.	Extract Bit from Integer
//Write an expression that extracts from given integer n the value of given bit at index p. 
//Examples:
//n	    binary representation	    p	bit @ p
//5	    00000000    00000101	    2	1
//0	    00000000    00000000	    9	0
//15	00000000    00001111	    1	1
//5343	00010100    11011111	    7	1
//62241	11110011    00100001	    11	0

//http://www.introprogramming.info/intro-csharp-book/read-online/glava3-operatori-i-izrazi/
//Дадено е число n и позиция p. Напишете поредица от операции, 
//които да отпечатат стойността на бита на позиция p от числото n (0 или 1). 
//Пример: n=35, p=5 -> 1. Още един пример: n=35, p=6 -> 0.
//Ползвайте побитови операции:

//int n = 35; // 00100011
//int p = 6;
//int i = 1; // 00000001

//int mask = i << p; // Move the 1st bit left by p positions
//// If i & mask are positive then the p-th bit of n is 1
//Console.WriteLine((n & mask) != 0 ? 1 : 0);
// (n и mask) не са равни на 0.. пиши 1 или ако не е вярно пиши 0 

//Console.WriteLine((n & mask) = 0 ? 0 : 1);

namespace _12.ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number = ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter the position = ");
            int position = int.Parse(Console.ReadLine());

            int mask = 1 << position;
            int addMask = number & mask;
            Console.WriteLine("Bit @ p: " + ((addMask != 0) ? "1" : "0").ToString());

            //Console.WriteLine("Third bit is '0' " + Convert.ToString(number, 2).PadLeft(16, '0'));

        }
    }
}
