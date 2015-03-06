using System;

//Problem 10.	Odd and Even Product
//You are given n integers (given in a single line, separated by a space). Write a program that checks whether 
//the product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n, 
//so the first element is odd, the second is even, etc. Examples:

//2 1 1 6 3	            3 10 4 6 5 1            4 3 2 5 2	
//yes                   yes                     no
//product = 6           product = 60            odd_product = 16
//                                              odd_product = 15


class Program
{
    static void Main()
    {

        string values = Console.ReadLine();
        string[] tokens = values.Split(' ');

        int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);

        //for (int i = 0; i < convertedItems.Length; i++)
        //{
        //    Console.WriteLine(convertedItems[i]);
        //}



        int oddSum = 1;
        int evenSum = 1;


        for (int i = 0; i < convertedItems.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenSum *= convertedItems[i];
            }
            else
            {
                oddSum *= convertedItems[i];
            }
        }

        if (oddSum==evenSum)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = " + oddSum);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = " + oddSum);
            Console.WriteLine("even_product = " + evenSum);
        }

    }
}