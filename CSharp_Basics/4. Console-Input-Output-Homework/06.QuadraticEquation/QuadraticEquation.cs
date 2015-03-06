using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 6.	Quadratic Equation
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 
//and solves it (prints its real roots). 
//Examples:
//  a	    b	c	    Roots
//  2	    5	-3	    x1=-3; x2=0.5
//  -1	    3	0	    x1=3; x2=0
//  -0.5	4	-8	    x1=x2=4
//  5	    2	8	    no real roots


namespace _06.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            
    //Quadratic Equation in Standard Form: ax2 + bx + c = 0
    //Quadratic Equations can be factored
    //Quadratic Formula: x = [ -b ± √(b^2-4ac) ] / 2a

    //When the Discriminant (b^2-4ac) is:
    //    positive, there are 2 real solutions      (b^2-4ac)>0
    //    zero, there is one real solution          (b^2-4ac)=0
    //    negative, there are 2 complex solutions   (b^2-4ac)<0 ---> no real roots

            Console.Write("Enter the first coef A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the second coef B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the thurd coef C: ");
            double c = double.Parse(Console.ReadLine());

            double dDeterm = (b * b) - (4 * a * c);
            double root1;
            double root2;
            Console.WriteLine();

            if (dDeterm > 0)
            {
                root1 = (-b - Math.Sqrt(dDeterm)) / (2 * a);
                root2 = (-b + Math.Sqrt(dDeterm)) / (2 * a);
                Console.WriteLine("x1 = {0}; x2 = {1}", root1, root2);
            }
            else if (dDeterm == 0)
            {
                root1 = root2 = (-b - Math.Sqrt(dDeterm)) / (2 * a);
                Console.WriteLine("x1=x2={0}", root1);
            }
            else
            {
                Console.WriteLine("No real roots.");
            }
        }
    }
}
