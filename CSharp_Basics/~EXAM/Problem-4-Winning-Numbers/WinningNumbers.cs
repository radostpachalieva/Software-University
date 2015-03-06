﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4_Winning_Numbers
{
    class WinningNumbers
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            // Calculate the expected sum
            int letSum = 0;
            string inputUppercase = input.ToUpper();
            for (int i = 0; i < inputUppercase.Length; i++)
            {
                letSum += inputUppercase[i] - 'A' + 1;
            }

            // Find all winning numbers
            int count = 0;

            for (int i1 = 0; i1 <= 9; i1++)
            {
                for (int i2 = 0; i2 <= 9; i2++)
                {
                    for (int i3 = 0; i3 <= 9; i3++)
                    {
                        if (i1 * i2 * i3 == letSum)
                        {
                            for (int i4 = 0; i4 <= 9; i4++)
                            {
                                for (int i5 = 0; i5 <= 9; i5++)
                                {
                                    for (int i6 = 0; i6 <= 9; i6++)
                                    {
                                        if (i4 * i5 * i6 == letSum)
                                        {
                                            Console.WriteLine("{0}{1}{2}-{3}{4}{5}",
                                                i1, i2, i3, i4, i5, i6);
                                            count++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No");
            }

        }
    }
}
