using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 4.	Rectangles
//Write an expression that calculates rectangle’s perimeter and area by given width and height. 
//Examples:
//width	height	perimeter	area
//3 	4	    14	        12
//2.5	3	    11	        7.5
//5	    5	    20	        25

//Area of Rectangle = b×h 
//Perimeter of Rectangle = 2(b) + 2(h)


namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the width: ");
            double widthRectangle = double.Parse(Console.ReadLine());
            Console.Write("Enter the height: ");
            double heightRectangle = double.Parse(Console.ReadLine());

            double perimeterRectangle = 2 * (widthRectangle + heightRectangle);
            double areaRectangle = widthRectangle * heightRectangle;
            
            Console.WriteLine("Perimeter of Rectangle = " + perimeterRectangle);
            Console.WriteLine("Area of Rectangle = " + areaRectangle);
        }
    }
}
