using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5_Double_Downs2
{
    class Program
    {
        static void Main(string[] args)
        {

            byte amount = byte.Parse(Console.ReadLine());
            string[] numbers = new string[amount];

            int rightDiagCount = 0;
            int leftDiagCount = 0;
            int vertDiagCount = 0;

            for (int i = 0; i < amount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = Convert.ToString(number,2).PadLeft(32, '0');
                Console.WriteLine(numbers[i]);

                char[] numbersChar = numbers[i].ToCharArray();
                Array.Reverse(numbersChar);
                numbers[i] = numbersChar.ToString();

            }

            

            Console.WriteLine(rightDiagCount);
            Console.WriteLine(leftDiagCount);
            Console.WriteLine(vertDiagCount);

        }
    }
}
