using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 8.	Isosceles Triangle
//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©
//  © ©
// ©   ©
//© © © ©
//Note that the © symbol may be displayed incorrectly at the console so you may need to change the console 
//character encoding to UTF-8 and assign a Unicode-friendly font in the console. Note also, that under old versions 
//of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.


namespace _08.IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            Console.Title = "Problem 8. Isosceles Triangle";

            //-----------------------------------------------------------------------------------------------
            // Solution 1 /What kind of code my brain can produce :D/:
            Console.OutputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.Unicode;
            char copyRight = '\u00A9';

            Console.WriteLine(" " + " " + " " + copyRight);
            Console.WriteLine(" " + " " + copyRight + " " + copyRight);
            Console.WriteLine(" " + copyRight + " " + " " + " " + copyRight);
            Console.WriteLine(copyRight + " " + copyRight + " " + copyRight + " " + copyRight);



            //-----------------------------------------------------------------------------------------------
            // Solution 2:
            char copyRightTwo = '©';
            Console.WriteLine(@"
   {0}
  {0} {0}
 {0}   {0}
{0} {0} {0} {0}", copyRightTwo);       



            //-----------------------------------------------------------------------------------------------
            // Solution 3 /from Julia.. What kind of code the smart people are typing :D/:
            // This code is for me and the people who want to see other implementation of the task.. 
            // so is't like private notice. Don't rate it. Just read it. Understand it. :)
            //https://github.com/Y-LyN-10/Software-University-Courses/tree/master/CSharp-Basics/%5BHW%5DPrimitiveDataTypesAndVariables
            

            //Console.OutputEncoding = System.Text.Encoding.Unicode;
            //char copyRight = '\u00A9';
            //char emptySpace = (char)0;
            //// To print a triangle, we need rows, columns and symbols.
            //// To print exactly 9 symbols, we need 5 columns and 3 rows.
            //int rows = 3;
            //int columns = 5;
            //int cSymbol = 1;
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int blank = 0; blank < columns - i; blank++)
            //    {
            //        Console.Write(emptySpace);
            //    }
            //    for (int symbol = 0; symbol < cSymbol; symbol++)
            //    {
            //        Console.Write(copyRight);
            //    }
            //    cSymbol += 2;
            //    Console.WriteLine();
            //}



            //-----------------------------------------------------------------------------------------------
            // Solution 4 /from Julia.. What kind of code the smart people are typing :D/:
            // This code is for me and the people who want to see other implementation of the task.. 
            // so is't like private notice. Don't rate it. Just read it. Understand it. :)
            //https://github.com/Y-LyN-10/Software-University-Courses/tree/master/CSharp-Basics/%5BHW%5DPrimitiveDataTypesAndVariables


            //Console.Write("Write the height: ");
            //int n = int.Parse(Console.ReadLine()); // read the height of the triangle
            ////To print a figure with empty spaces outside and
            ////inside, we need a variables to count them
            //int outerSpace = n - 1;
            //int innerSpace = 1;
            ////Print the top of the triangle
            //Console.WriteLine(new string(' ', n) + "@" + new string(' ', n));
            ////The middle of the triangle we print with a loop, printing so many lines as needed.
            //// n - 2, because the first line and the bottom are printed separately from this loop
            //for (int i = 1; i <= n - 2; i++)
            //{
            //    Console.Write(new string(' ', outerSpace)); // first time, outerSpace = n - 1.
            //    Console.Write("@");
            //    Console.Write(new string(' ', innerSpace)); // first time, innterSpace symbol is printed only once.
            //    Console.WriteLine("@");
            //    outerSpace--; //In every loop repeat outerSpace counter decreases
            //    innerSpace += 2; //with 1 and innerSpace counter increases with 2.
            //}
            ///*Print the bottom of the triangle (I made it with
            //empty intervals between copyright symbols.)*/
            //Console.Write(new string(' ', outerSpace));
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write('@');
            //    Console.Write(' ');
            //}
            //Console.WriteLine(new string(' ', outerSpace));

        }
    }
}
