using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 1.	Declare Variables
//Declare five variables choosing for each of them the most appropriate of the types 
//byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 
//52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure it 
//will fit in it. Try to compile the code. Submit the source code of your 
//Visual Studio project as part of your homework submission.



namespace _01.DeclareVariables
{
    class DeclareVariables
    {
        static void Main(string[] args)
        {
            Console.Title = "Problem 1.	Declare Variables";
            ushort numberOne =  52130;     // 0, 0, 65535
            sbyte numberTwo = -115;        // 0, -128, 127
            int numberThree = 4825932;       // 0, -2147483648, 2147483647
            byte numberFour = 97;           // 0, 0, 255 .. or with sbyte
            short numberFive = -10000;      // 0, -32768, 32767


            Console.WriteLine((numberOne) + (" is ushort "));
            Console.WriteLine((numberTwo) + (" is sbyte "));
            Console.WriteLine((numberThree) + (" is int "));
            Console.WriteLine((numberFour) + (" is byte "));
            Console.WriteLine((numberFive) + (" is short"));
        }
    }
}
