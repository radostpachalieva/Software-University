using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 4.	Unicode Character
//Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) 
//using the '\u00XX' syntax, and then print it. Hint: first, use the Windows Calculator to find the 
//hexadecimal representation of 42. The output should be “*”.

//https://github.com/ipobornik/TelerikSoftwareAcademy/blob/master/CSharp%20Part1%20-%20course%202013/02%20Primitive%20Data%20Types%20And%20Variables/05%20DeclareChar72/DeclareChar72.cs
//http://www.ascii-code.com/


namespace _04.UnicodeCharacter
{
    class UnicodeCharacter
    {
        static void Main(string[] args)
        {
            Console.Title = "Problem 4. Unicode Character";
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            char variableChar = '\u0042';
            Console.WriteLine("The symbol that has Unicode code 42 (decimal) using the \'\\u00XX\' syntax is " + variableChar);
        }
    }
}
