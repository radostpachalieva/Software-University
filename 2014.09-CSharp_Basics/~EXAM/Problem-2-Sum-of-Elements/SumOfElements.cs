using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_Sum_of_Elements
{
    class SumOfElements
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] spaces = input.Split(' ');
            double[] numbers = new double[spaces.Length];
            for (int i = 0; i < spaces.Length; i++)
            {
                numbers[i] = double.Parse(spaces[i]);
            }


            double max = numbers.Max();
            double sum = numbers.Sum();

            if (max == sum - max)
            {
                Console.WriteLine("Yes, sum={0}", max);
            }
            if (max != sum - max)
            {
                Console.WriteLine("No, diff={0}", Math.Abs(max - (sum - max)));
            }

        }
    }
}
