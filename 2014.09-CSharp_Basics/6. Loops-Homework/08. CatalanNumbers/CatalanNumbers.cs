using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 8.	Catalan Numbers
//In combinatorics, the Catalan numbers are calculated by the formula.  
//Write a program to calculate the nth Catalan number by given n (1 < n < 100). 
//Examples:
//n	Catalan(n)
//0	1
//5	42
//10	16796
//15	9694845

namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {

            //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            //Console.Write("n = ");
            //int n = int.Parse(Console.ReadLine());

            //double factorielN = 1;
            //double factorielDoubleN = 1;
            //double factorielNPlus = 1;

            //for (int i = 1; i <= 2 * n; i++)
            //{
            //    factorielDoubleN *= i;
            //}

            //for (int i = 1; i <= n; i++)
            //{
            //    factorielN *= i;
            //}

            //for (int i = 1; i <= n + 1; i++)
            //{
            //    factorielNPlus *= i;
            //}

            //double totalResult = factorielDoubleN / (factorielNPlus*factorielN);

            //Console.WriteLine("Result = " + totalResult);

            //-----------------------------------------------------------------------
            Console.Write("Give me a number for 'n', please:  ");
            int n = int.Parse(Console.ReadLine());

            int middleProduct = 1;
            decimal product = 1;

            int nPlusOne = n + 1;
            for (int i = 2 * n; i > nPlusOne; i--)
            {
                middleProduct *= i;
            }

            product *= middleProduct;
            for (int i = 1; i <= n; i++)
            {
                product /= i;
            }

            Console.WriteLine("(2n)! / (n + 1)! * n! = {0}", product);   

        }
    }
}
