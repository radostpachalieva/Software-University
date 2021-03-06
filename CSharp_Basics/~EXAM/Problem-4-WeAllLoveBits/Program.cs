﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int bits = int.Parse(Console.ReadLine());
            int result = 0;
            while (bits>0)
            {
                int lastBit = bits & 1;
                result = result << 1;
                result = result | lastBit;
                bits = bits >> 1;
            }
            Console.WriteLine(result);
        }
    }
}