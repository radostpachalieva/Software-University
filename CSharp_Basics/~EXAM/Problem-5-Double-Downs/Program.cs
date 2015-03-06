using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5_Double_Downs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            byte amount = byte.Parse(Console.ReadLine());
            int[] numbers = new int[amount];

            int rightDiagCount = 0;
            int leftDiagCount = 0;
            int vertDiagCount = 0;

            for (int i = 0; i < amount; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int topNumb = numbers[i];
                int bottomNumb = numbers[i + 1];
                for (int bit = 0; bit < 32; bit++)
                {
                    int mask = 1 << bit;
                    bool checkTopBit = (topNumb & mask) > 0;
                    if (checkTopBit && (bottomNumb&(mask>>1))>0)
                    {
                        rightDiagCount++;
                    }

                    if (checkTopBit && (bottomNumb & (mask << 1)) > 0)
                    {
                        leftDiagCount++;
                    }

                    if (checkTopBit && (bottomNumb & mask) > 0)
                    {
                        vertDiagCount++;
                    }
                }
            }

            Console.WriteLine(rightDiagCount);
            Console.WriteLine(leftDiagCount);
            Console.WriteLine(vertDiagCount);
        }
    }
}
