using System;


class Program
{
    static void Main(string[] args)
    {
//Input
//The input data should be read from the console.
//On the only line will hold and integer number N (always odd number), indicating the width of the arrow. 

//Output
//Use the “#” (number sign) to mark the arrow and “.” (dot) for the rest. Follow the examples below.

        int n = int.Parse(Console.ReadLine());

        int dotCountOut = n / 2;
        int dotCountIn = n - 2;

        Console.WriteLine("{0}{1}{0}", new string('.',dotCountOut), new string('#', n));

        for (int i = 1; i <= n - 2; i++)
        {
            Console.Write(new string('.', dotCountOut));
            Console.Write('#');
            Console.Write(new string('.', dotCountIn));
            Console.Write('#');
            Console.Write(new string('.', dotCountOut));
            Console.WriteLine();
        }

        Console.WriteLine("{0}{1}{0}", new string('#', dotCountOut+1), new string('.', dotCountIn));

        for (int i = 1; i <= n -2 ; i++)
        {
            Console.Write(new string('.', i));
            Console.Write('#');
            Console.Write(new string('.',  (n - 2*i +dotCountIn - 1)));
            Console.Write('#');
            Console.Write(new string('.', i));
            Console.WriteLine();
        }

        Console.WriteLine("{1}{0}{1}", new string('#', 1), new string('.', n-1));
    }
}