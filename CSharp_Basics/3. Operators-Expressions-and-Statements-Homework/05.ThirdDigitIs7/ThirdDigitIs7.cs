using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 5.	Third Digit is 7?
//Write an expression that checks for given integer if its third digit from right-to-left is 7. 
//Examples:
//n	        Third digit 7?
//5	        false
//701	    true
//9703	    true
//877	    false
//777877	false
//9999799	true


namespace _05.ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());

            int restNumber = number / 100;          // 123456789 / 100 = 123456.789 = 123456
            int thirdDigit = restNumber % 10;       // 123456 % 10 http://msdn.microsoft.com/en-us/library/0w4e0fzs.aspx

            bool isSeven = thirdDigit == 7;         // http://msdn.microsoft.com/en-us/library/53k8ybth.aspx

            //bool isSeven = (thirdDigit == 7) || (thirdDigit == -7);       //// http://msdn.microsoft.com/en-us/library/6373h346.aspx

            Console.WriteLine("Third digit of {0} is 7 = " + isSeven, number);
        }
    }
}
