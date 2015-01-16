using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 9.	Trapezoids
//Write an expression that calculates trapezoid's area by given sides a and b and height h. Examples:
//a	        b	    h	    area	 
//5	        7	    12	    72	
//2	        1	    33	    49.5	
//8.5	    4.3	    2.7	    17.28	
//100	    200	    300	    45000	
//0.222	    0.333	0.555	0.1540125	

//A = ((a+b)*h)/2


namespace _09.Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            Console.Write("Enter given side 'a': ");
            double sideA = double.Parse(Console.ReadLine());

            Console.Write("Enter given side 'b': ");
            double sideB = double.Parse(Console.ReadLine());

            Console.Write("Enter height 'h': ");
            double height = double.Parse(Console.ReadLine());

            double trapezoidArea = ((sideA + sideB) * height) / 2;

            Console.WriteLine("Trapezoid's area = {0}", trapezoidArea);
        }
    }
}
