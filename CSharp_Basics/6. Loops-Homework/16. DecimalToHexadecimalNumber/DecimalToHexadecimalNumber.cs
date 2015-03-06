using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.DecimalToHexadecimalNumber
{
    class DecimalToHexadecimalNumber
    {

        static void Main(string[] args)
        {
            Console.Write("Decimal Number: ");
            long decimalNumber = long.Parse(Console.ReadLine());

            ConvertToHexadecimal(decimalNumber);
        }

        static void ConvertToHexadecimal(long decimalNumber)
        {
            string number = "";
            List<string> hexadecimalNumber = new List<string>();

            //Just reverse the previous exercise. This time the List is of strings.
            //And if the number is between 10 and 15, we assingn it with a letter.

            while (decimalNumber > 0)
            {
                number = "" + decimalNumber % 16;

                if (number == "10") number = "A";
                if (number == "11") number = "B";
                if (number == "12") number = "C";
                if (number == "13") number = "D";
                if (number == "14") number = "E";
                if (number == "15") number = "F";

                hexadecimalNumber.Add("" + number);
                number = "";
                decimalNumber = decimalNumber / 16;
            }

            hexadecimalNumber.Reverse(); //Reverse the List

            //Print the result:
            Console.Write("Hexadecimal:    ");
            foreach (string element in hexadecimalNumber) Console.Write(element);
            Console.WriteLine();
        }

    }
}
