using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_Odd_Even_Elements
{
    class Odd_Even_Elements
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture =
            System.Globalization.CultureInfo.InvariantCulture;

            decimal oddSum = 0;
            decimal oddMin = decimal.MaxValue;
            decimal oddMax = decimal.MinValue;
            decimal evenSum = 0;
            decimal evenMin = decimal.MaxValue;
            decimal evenMax = decimal.MinValue;

            string input = Console.ReadLine();
            string[] inputNumbers = input.Split(' ');
            if (input == "")
            {
                // Known issue: split on empty string returns 1 token ""
                inputNumbers = new string[0];
            }

            bool odd = true;
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                decimal element = decimal.Parse(inputNumbers[i]);
                if (odd)
                {
                    oddSum += element;
                    oddMin = Math.Min(oddMin, element);
                    oddMax = Math.Max(oddMax, element);
                }
                else
                {
                    evenSum += element;
                    evenMin = Math.Min(evenMin, element);
                    evenMax = Math.Max(evenMax, element);
                }
                odd = !odd;
            }

            if (inputNumbers.Length == 0)
            {
                Console.WriteLine(
                    "OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
            }
            else if (inputNumbers.Length == 1)
            {
                Console.WriteLine(
                    "OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No",
                    (double)oddSum, (double)oddMin, (double)oddMax);
            }
            else
            {
                Console.WriteLine(
                    "OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                    (double)oddSum, (double)oddMin, (double)oddMax,
                    (double)evenSum, (double)evenMin, (double)evenMax);
            }





            // -------------------------------------------------------------------------
            //string inputLine = Console.ReadLine();
            //string[] elements = inputLine.Split(' ');

            //double OddSum = 0;
            //double OddMin = 1000000;
            //double OddMax = -1000000;
            //double EvenSum = 0;
            //double EvenMin = 1000000;
            //double EvenMax = -1000000;

            //for (int i = 0; i < elements.Length; i++)
            //{
            //    double iElement = double.Parse(elements[i]);


            //    if (iElement % 2 == 0)
            //    {
            //        OddSum += iElement;

            //        if (OddMin > iElement)
            //            OddMin = iElement;

            //        if (OddMax < iElement)
            //            OddMax = iElement;
            //    }


            //    else
            //    {
            //        EvenSum += iElement;

            //        if (EvenMin > iElement)
            //            EvenMin = iElement;


            //        if (EvenMax < iElement)
            //            EvenMax = iElement;
            //    }

            //}

            //Console.Write("OddSum=" + OddSum);
            //Console.Write(", OddMin=" + OddMin);
            //Console.Write(", OddMax=" + OddMax);
            //Console.Write(", EvenSum=" + EvenSum);
            //Console.Write(", EvenMin=" + EvenMin);
            //Console.Write(", EvenMax=" + EvenMax);
            //Console.WriteLine();
            ////"No"


        }
    }
}
