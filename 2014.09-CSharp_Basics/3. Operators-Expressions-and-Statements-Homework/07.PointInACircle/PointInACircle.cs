using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 7.	Point in a Circle
//Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 
//Examples:
//x	        y	    inside	 
//0     	1	    true	
//-2	    0	    true	
//-1	    2	    false	
//1.5	    -1	    true	
//-1.5	    -1.5	false	
//100	    -30	    false	
//0	        0	    true	
//0.2	    -0.8	true	
//0.9	    -1.93	false	
//1	        1.655	true	


namespace _07.PointInACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            Console.Write("Input x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Input y: ");
            double y = double.Parse(Console.ReadLine());

            double radius = 2;
            bool isInside = (x * x) + (y * y) <= (radius * radius);

            Console.WriteLine("These coordinates are inside the circle = " + isInside);
        }
    }
}
