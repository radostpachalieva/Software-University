﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5_Friend_Bits
{
    class Program
    {
        static void Main(string[] args)
        {

            uint n = uint.Parse(Console.ReadLine());
            uint friendBits = 0;
            uint aloneBits = 0;
            for (int i = 31; i >= 0; i--)
            {
                uint currentBit = (n >> i) & 1;

                bool hasLeftBit = (i < 31);
                uint leftBit = (n >> (i + 1)) & 1;
                bool sameLeftBit = hasLeftBit && (leftBit == currentBit);

                bool hasRightBit = (i > 0);
                uint rightBit = (n >> (i - 1)) & 1;
                bool sameRightBit = hasRightBit && (rightBit == currentBit);

                bool friendBit = sameLeftBit || sameRightBit;
                if (friendBit)
                {
                    friendBits = (friendBits << 1) | currentBit;
                }
                else
                {
                    aloneBits = (aloneBits << 1) | currentBit;
                }
            }
            Console.WriteLine(friendBits);
            Console.WriteLine(aloneBits);


        }
    }
}
