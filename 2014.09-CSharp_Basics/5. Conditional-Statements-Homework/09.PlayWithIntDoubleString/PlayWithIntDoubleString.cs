using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 9.	Play with Int, Double and String
//Write a program that, depending on the user’s choice, inputs an int, double or string variable. 
//If the variable is int or double, the program increases it by one. If the variable is a string, 
//the program appends "*" at the end. Print the result at the console. Use switch statement. 
//Example:

//program	user
//Please choose a type:
//1 --> int
//2 --> double
//3 --> string	3
//Please enter a string:	hello
//hello*	

//program	user
//Please choose a type:
//1 --> int
//2 --> double
//3 --> string	2
//Please enter a double:	1.5
//2.5	


namespace _09.PlayWithIntDoubleString
{
    class PlayWithIntDoubleString
    {
        static void Main(string[] args)
        {
            Console.Write("What is your choice: int, double, or a string variable? ");
            string input = Console.ReadLine();

            Console.Write("Enter a value for {0}:  ", input);

            switch (input)
            {
                case "i":
                case "int":
                case "integer":
                    int i = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: {0}", i + 1); break;

                case "d":
                case "double":
                    double d = double.Parse(Console.ReadLine());
                    Console.WriteLine("Result: {0}", d + 1); break;

                case "s":
                case "str":
                case "string":
                    string s = Console.ReadLine();
                    Console.WriteLine("Result: {0}*", s); break;
            }
        }
    }
}
