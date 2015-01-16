using System;

//Problem 16.	* Print Long Sequence
//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … 
//You might need to learn how to use loops in C# (search in Internet).


namespace _16.PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main(string[] args)
        {


            // Way 1: Mathematical
            for (int i = 1; i < 1001; i++)
            {
                double a = Math.Pow((-1), i);
                double b = (i + 1);
                Console.WriteLine((-1) * a * b);
            }

            //-------------------------------------
            // Way 2: Using if and else

            //int Number;
            //for (int i = 2; i <= 1001; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Number = i;
            //    }
            //    else
            //    {
            //        Number = i * (-1);
            //    }
            //    Console.WriteLine(Number);
            //}


        }
    }
}
