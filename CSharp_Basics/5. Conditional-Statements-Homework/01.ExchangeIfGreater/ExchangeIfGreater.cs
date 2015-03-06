using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 1.	Exchange If Greater
//Write an if-statement that takes two integer variables a and b and exchanges their values 
//if the first one is greater than the second one. As a result print the values a and b, separated by a space. 
//Examples:
//a	b	result
//5	2	2 5
//3	4	3 4
//5.5	4.5	4.5 5.5


namespace _01.ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                Console.Write(a);
                Console.Write(' ');
                Console.Write(b);
            }
            else
            {
                Console.Write(b);
                Console.Write(' ');
                Console.Write(a);
            }
            Console.WriteLine(a);

//-------------------------------------------------------
            //NumberFormatInfo n = CultureInfo.InvariantCulture.NumberFormat;

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine((a < b) ? (a.ToString(n) + ' ' + b.ToString(n)) : (b.ToString(n) + ' ' + a.ToString(n)));





            //----------------------------------------------------


            //Console.Write("Please, enter a:");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Please, enter b:");
            //double b = double.Parse(Console.ReadLine());
            //if (a > b)
            //{
            //    Console.WriteLine("Exchange needed:{0} <===> {1}", a, b);
            //    double greaterNumber = a;
            //    a = b;
            //    b = greaterNumber;
            //    Console.WriteLine(a + " " + b);
            //}
            //else
            //{
            //    Console.WriteLine("No Exchange needed:{0} <===> {1}", a, b);
            //    Console.WriteLine(a + " " + b);
            //}       


            //---------------------------------------

        //    Console.Write("Please, enter score from 1 to 9:");
        //int score =int.Parse(Console.ReadLine());
        //switch (score)
        //{
        //    case 1:
        //    case 2:
        //    case 3:
        //        Console.WriteLine("The bonus is {0}",score*10);
        //        break;
        //    case 4:
        //    case 5:
        //    case 6:
        //        Console.WriteLine("The bonus is {0}",score*100);
        //        break;
        //    case 7:
        //    case 8:
        //    case 9:
        //        Console.WriteLine("The bonus is {0}",score*1000);
        //        break;
        //    default:
        //        Console.WriteLine("You enter wrong score.Please, try again");
        //    break;

        }
    }
}