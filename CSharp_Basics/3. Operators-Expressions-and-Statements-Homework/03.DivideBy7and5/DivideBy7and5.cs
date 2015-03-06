using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 3.	Divide by 7 and 5
//Write a Boolean expression that checks for given integer if it can be divided (without remainder) 
//by 7 and 5 in the same time. 
//Examples:
//n	    Divided by 7 and 5?
//3	    false
//0	    false
//5	    false
//7	    false
//35	true
//140	true


namespace _03.DivideBy7and5
{
    class DivideBy7and5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            bool dividable = (number % 5 == 0) && (number % 7 == 0);
            //bool dividable = (number % 35 == 0) && (number != 0);

            Console.WriteLine("The number \"{0}\" can be divided by 7 and 5 = {1} ", number, dividable);

        }
    }
}
