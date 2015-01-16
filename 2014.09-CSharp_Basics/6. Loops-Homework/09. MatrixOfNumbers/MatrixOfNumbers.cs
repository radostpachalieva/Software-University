﻿using System;

//Problem 9.	Matrix of Numbers
//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix 
//like in the examples below. Use two nested loops. Examples:
//  n	matrix
//  2	1 2
//      2 3

//  n	matrix
//  3	1 2 3
//      2 3 4
//      3 4 5


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(j + i + " ");
            }
            Console.WriteLine();
        }
    }
}

