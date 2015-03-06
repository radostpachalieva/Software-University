using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 3.	Circle Perimeter and Area
//Write a program that reads the radius r of a circle and prints its perimeter and area 
//formatted with 2 digits after the decimal point. 
//Examples:
//  r	    perimeter	area
//  2	    12.57	    12.57
//  3.5	    21.99	    38.48


namespace _03.CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {

            Console.Write("The radius of a circle: ");
            double radius = double.Parse(Console.ReadLine());

            double pi = Math.PI;

            Console.WriteLine("The Perimeter of a circle = {0:F2}", pi * 2 * radius);
            Console.WriteLine("The Area of a circle = {0:F2}", pi * radius * radius);

        }
    }
}
