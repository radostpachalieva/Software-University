using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_Odd_Even_Jumps
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputString = Console.ReadLine()
                .ToLower()
                .Split(new string[] { " " },StringSplitOptions.RemoveEmptyEntries);

            string processedInput = string.Join("", inputString);

            int oddJump = int.Parse(Console.ReadLine());
            int evenJump = int.Parse(Console.ReadLine());

            ulong oddResult = 0;
            ulong evenResult = 0;
            int currentJumpPosition = 1;

            currentJumpPosition = 1;
            //Odd
            for (int i = 0; i < processedInput.Length; i+=2)
            {
                ulong currentSymbol = (ulong)processedInput[i];
                if (currentJumpPosition == oddJump)
                {
                    oddResult *= currentSymbol;
                    
                }
                else
                {
                    oddResult += currentSymbol;
                }
                currentJumpPosition++;
            }

            currentJumpPosition = 1;
            //even chars
            for (int i = 1; i < processedInput.Length; i += 2)
            {
                ulong currentSymbolCode = (ulong)processedInput[i];

                if (currentJumpPosition == evenJump)//odd chars
                {
                    evenResult *= (ulong)currentSymbolCode;
                    
                }
                else//even chars
                {
                    evenResult += (ulong)currentSymbolCode;
                    currentJumpPosition++;
                }
            }
            Console.WriteLine("Odd: {0:X}", oddResult);
            Console.WriteLine("Even: {0:X}", evenResult);

        }
    }
}
