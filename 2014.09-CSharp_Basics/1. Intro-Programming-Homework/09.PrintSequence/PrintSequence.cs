using System;

//Problem 9.	Print a Sequence
//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
// -((-1)^i)*(i+1)


namespace _09.PrintSequence
{
    class PrintSequence
    {
        static void Main()
        {


            // Way 1: Mathematical
            for (int i = 1; i < 11; i++)
            {
                double a = Math.Pow((-1), i);
                double b = (i + 1);
                Console.WriteLine((-1) * a * b);
            }

            //-------------------------------------
            // Way 2: Using if and else

            //int Number;
            //for (int i = 2; i <= 11; i++)
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

