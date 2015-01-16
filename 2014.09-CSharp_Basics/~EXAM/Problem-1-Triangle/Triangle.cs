using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int aX = int.Parse(Console.ReadLine());
            int aY = int.Parse(Console.ReadLine());
            int bX = int.Parse(Console.ReadLine());
            int bY = int.Parse(Console.ReadLine());
            int cX = int.Parse(Console.ReadLine());
            int cY = int.Parse(Console.ReadLine());

            double aDist = Math.Sqrt(Math.Pow((bX - aX), 2) + Math.Pow((bY - aY), 2));
            double bDist = Math.Sqrt(Math.Pow((cX - bX), 2) + Math.Pow((cY - bY), 2));
            double cDist = Math.Sqrt(Math.Pow((aX - cX), 2) + Math.Pow((aY - cY), 2));

            //Console.WriteLine("{0:0.00}", aDist);
            //Console.WriteLine("{0:0.00}", bDist);
            //Console.WriteLine("{0:0.00}", cDist);


            //Console.WriteLine("{0:0.00}", aDist);
            double p = (aDist + bDist + cDist) / 2;
            double area = Math.Sqrt(Math.Abs(p * (p - aDist) * (p - bDist) * (p - cDist))); //Area=√(p(p-a)(p-b)(p-c) ), where p is half the perimeter: (a+b+c)/2

            if (aDist + bDist > cDist && bDist + cDist > aDist && aDist + cDist > bDist)            //a+b>c;  b+c>a; a+c>b
            {
                Console.WriteLine("Yes");
                Console.WriteLine("{0:0.00}", area);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("{0:0.00}", aDist);
            }



            // ---------------------------------------------------------------------------------

            //int aX = int.Parse(Console.ReadLine());
            //int aY = int.Parse(Console.ReadLine());
            //int bX = int.Parse(Console.ReadLine());
            //int bY = int.Parse(Console.ReadLine());
            //int cX = int.Parse(Console.ReadLine());
            //int cY = int.Parse(Console.ReadLine());

            //double ab = Math.Sqrt(
            //    (bX - aX) * (bX - aX) +
            //    (bY - aY) * (bY - aY));

            //double bc = Math.Sqrt(
            //    (bX - cX) * (bX - cX) +
            //    (bY - cY) * (bY - cY));

            //double ac = Math.Sqrt(
            //    (cX - aX) * (cX - aX) +
            //    (cY - aY) * (cY - aY));

            //bool areFormingTriangle =
            //    (ab + bc > ac && ab + ac > bc && ac + bc > ab);

            //if (areFormingTriangle == false)
            //{
            //    Console.WriteLine("No");
            //    Console.WriteLine("{0:F2}", ab);
            //}
            //else
            //{
            //    Console.WriteLine("Yes");
            //    double p = (ab + bc + ac) / 2;
            //    double area = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
            //    Console.WriteLine("{0:F2}", area);
            //}

        }
    }
}
