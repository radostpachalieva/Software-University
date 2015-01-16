using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] m = new int[8,8];

        for (int row = 0; row <= 7; row++)
        {
            int bits = int.Parse(Console.ReadLine());
            for (int col = 0; col <= 7; col++)
            {
                m[row, col] = (bits >> (7-col)) & 1;    //измества се с номер на колоната
            }
            
        }
       
        //// за принт:
        //for (int row = 0; row <= 7; row++)
        //{
        //    for (int col = 0; col <= 7; col++)
        //    {
        //        Console.Write(m[row, col]);
        //    }
        //    Console.WriteLine();
        //}

        for (int i = 0; i <= 7; i++)
        {
            int leftCount = 0;
            int rightCount = 0;
            for (int row = 0; row <= 7; row++)
            {
                for (int col = 0; col <= 7; col++)
                {
                    if (col > i)
                    {
                        leftCount += m[row, col];
                    }
                    if (col < i)
                    {
                        rightCount += m[row, col];
                    }
                }
            }
            if (leftCount==rightCount)
            {
                Console.WriteLine(7 - i);
                Console.WriteLine(leftCount);
                return;
            }
        }
        Console.WriteLine("no");

/*
0
60
0
8
0
12
224
0
*/
    }
}
