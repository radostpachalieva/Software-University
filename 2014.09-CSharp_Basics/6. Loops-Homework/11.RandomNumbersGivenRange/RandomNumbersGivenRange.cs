using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.RandomNumbersGivenRange
{
    class RandomNumbersGivenRange
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            Random rand = new Random();

            for (int numbers = 1; numbers <= n; numbers++)
            {
                Console.Write(rand.Next(min, max + 1) + " ");
            }
            Console.WriteLine();
        }
    }
}
