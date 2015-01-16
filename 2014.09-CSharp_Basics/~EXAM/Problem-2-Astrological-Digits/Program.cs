using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_Astrological_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int calculated = 0;

            do
            {
                calculated=0;
                for (int i = 0; i < input.Length; i++) // вади само цифрите и ги събира!!!!
                {
                    //if (char.IsDigit(input[i])) // дали на определената позиция има цифра
                    if (input[i] != '.' && input[i] != '-')
                    {
                        calculated += (input[i] - '0'); // вземи символа и извади '0' - начин да се обърне цифра от char в цифра в int
                    }
                }

                input = calculated.ToString();
            }
            while(calculated>9);

           Console.WriteLine(calculated);

        }
    }
}